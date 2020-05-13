// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Unlit/DepthFog"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color("Color", Color) = (0,0,0,0)
        _UnderwaterBias("Underwater Bias", Range(0.0,1.0))= 0
        _UnderwaterFog("Underwater Fog", Range(0.0,1.0))= 0
        _UnderLineSmoothness("Smoothness", Range(0.0,1.0))= 0
        _DiffuseFactor("Diffuse factor", Range(0.0,1.0)) = 0
        _Transparency("Transparency", Range(0.0,1.0)) = 0
    }
    SubShader
    {
    
        Tags { "RenderType"="Transparent" "Queue" = "Transparent"}
        
        LOD 100
        Cull Off
        Blend SrcAlpha OneMinusSrcAlpha
        GrabPass { "_BackgroundTexture" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog
            #include "UnityCG.cginc"
            #include "UnityDeferredLibrary.cginc"
            
            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float3 normal : NORMAL;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
                float4 worldPos : TEXCOORD1;
                float3 normal : NORMAL;
                float4 screenPos : TEXCOORD2;
                float depth : DEPTH;
                float height : TEXCOORD3;
                float4 grabPos : TEXCOORD4;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            
            fixed4 _Color;
            float _UnderwaterBias;
            float _UnderwaterFog;
            float _UnderLineSmoothness;
            float _DiffuseFactor;
            float _Transparency;
            //the depth texture
            sampler2D _BackgroundTexture;


            v2f vert (appdata v)
            {
                v2f o;
                o.normal = v.normal;
                // o.normal.x += displacement;
                // v.vertex.y = p.y;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.worldPos = mul(UNITY_MATRIX_M, v.vertex);
                o.depth = -mul(UNITY_MATRIX_MV, v.vertex).z * _ProjectionParams.w;
                o.screenPos = ComputeScreenPos(o.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.grabPos = ComputeGrabScreenPos(o.worldPos);
                return o;
            }
      
            fixed4 frag (v2f i) : SV_Target
            {
                //Diffuse lighthing
                float3 light_direction = normalize(_WorldSpaceLightPos0.xyz) ;
                float diffuse_coeficient = clamp(dot(-light_direction,normalize(i.normal)),1-_DiffuseFactor,1) ;
                //DEPTH TEXTURE
                float raw_depth = tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.screenPos)).r;
                float existingDepthLinear = LinearEyeDepth(raw_depth) ;
                float depthDifference = (existingDepthLinear - i.screenPos.w );
                float waterDepthDifference01 = 1 - max(depthDifference,0); 

                //REFRACTION
                
                half4 underwater_color = tex2Dproj(_BackgroundTexture,i.screenPos);

                // return float4(i.height,0,0, 1);
                // return float4(1 - waterDepthDifference01.xxx,1);
                //tinting : float4(_Color.rgb  ,_Transparency)
                // return float4(fmod(_Time.y,1).xxx,1);

                //Texture

                float3 underwater_composite = underwater_color*_UnderwaterBias * max(lerp(1-_UnderwaterFog,1,waterDepthDifference01),0);
                
                float amount = 1-clamp(_UnderwaterBias * max(lerp(1-_UnderwaterFog,1,waterDepthDifference01),0),0,1);

                return float4(lerp(underwater_color.rgb,_Color.rgb,amount)  ,1);

                if( step(underwater_composite.r,0) <= 0)
                    return float4(underwater_composite* _UnderLineSmoothness,_Transparency) ;
                    //return float4(underwater_composite* _UnderLineSmoothness,_Transparency) ;
                 return ( _Color);
                // return float4(((_Color.rgb * (1 - _TextureTransparency) + (tex_color * _TextureTransparency)) + (float4(background_color* _TextureTransparency,1)) )  * (diffuse_coeficient ),1)  + (_FoamColor * step((1 -_FoamTickness) ,waterDepthDifference01 )) + specular_coeficient * _SpecularFactor;
            }
            
            float smoothstep(float edge0,float edge1, float x){
                float t = clamp((x - edge0) / (edge1 - edge0), 0.0, 1.0);
                return t * t * (3.0 - 2.0 * t);
            }
            ENDCG
        }
    }
}
