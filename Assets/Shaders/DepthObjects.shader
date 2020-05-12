// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Unlit/DepthObject"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color("Color", Color) = (0,0,0,0)
        _DiffuseFactor("Diffuse factor", Range(0.0,1.0)) = 0
        _Transparency("Transparency", Range(0.0,1.0)) = 0
    }
    SubShader
    {
       
        //Blend SrcAlpha OneMinusSrcAlpha
        //Cull Back
        Pass
        {
            Tags { "Queue" = "Geometry" "RenderType"="Opaque" "LightMode" = "ForwardBase" }
            LOD 100
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog
            #pragma alpha:fade
            #include "UnityCG.cginc"
            #include "UnityDeferredLibrary.cginc"
            #include "UnityLightingCommon.cginc"
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
            };
   
            sampler2D _MainTex;
            float4 _MainTex_ST;
            
            fixed4 _Color;
            float _DiffuseFactor;
            float _Transparency;


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
                return o;
            }
            float4 frag (v2f i) : SV_Target
            {
                //Diffuse lighthing
                float3 light_direction = normalize(_WorldSpaceLightPos0.xyz) ;
                float diffuse_coeficient = clamp(dot(-light_direction,normalize(i.normal)),1-_DiffuseFactor,1) ;
                //DEPTH TEXTURE
                float raw_depth = tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.screenPos)).r;
                float existingDepthLinear = LinearEyeDepth(raw_depth) ;
                
                float3 dir = (i.worldPos - _WorldSpaceCameraPos);
                dir.y = 0;
                dir = normalize(dir);
                float dist = (distance(i.worldPos,_WorldSpaceCameraPos) - 44/3)/100; 
                float depthDifference = (existingDepthLinear - i.screenPos.w - 900);
                float waterDepthDifference01 = 1 - max(depthDifference,0);

                float depth = saturate((existingDepthLinear) * (1 / 10));

                //Texture
                float4 tex_color = tex2D(_MainTex,(i.uv * _MainTex_ST.xy + (_MainTex_ST.zw )));

                float3 color_texture_composite = ((_Color.rgb ) )  *_LightColor + clamp(dist,0,1)* diffuse_coeficient ;

                //float3 underwater_composite = _UnderwaterBias * max(lerp(1-_UnderwaterFog,1,waterDepthDifference01),0);
                return float4(color_texture_composite,_Transparency);
                // return float4(((_Color.rgb * (1 - _TextureTransparency) + (tex_color * _TextureTransparency)) + (float4(background_color* _TextureTransparency,1)) )  * (diffuse_coeficient ),1)  + (_FoamColor * step((1 -_FoamTickness) ,waterDepthDifference01 )) + specular_coeficient * _SpecularFactor;
            }
            
            float smoothstep(float edge0,float edge1, float x){
                float t = clamp((x - edge0) / (edge1 - edge0), 0.0, 1.0);
                return t * t * (3.0 - 2.0 * t);
            }
            ENDCG
        }
     Pass
        {
            Tags { "LightMode" = "ForwardAdd" }
            Blend One One
            LOD 100
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog
            #pragma alpha:fade
            #include "UnityCG.cginc"
            #include "UnityDeferredLibrary.cginc"
            #include "UnityLightingCommon.cginc"
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
            };
   
            sampler2D _MainTex;
            float4 _MainTex_ST;
            
            fixed4 _Color;
            float _DiffuseFactor;
            float _Transparency;


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
                return o;
            }
            float4 frag (v2f i) : SV_Target
            {
                float3 fragmentToLightSource = _WorldSpaceLightPos0.xyz - i.worldPos.xyz;
                float distance = length(fragmentToLightSource);
                float3 lightDirection = normalize(fragmentToLightSource);
                float atten = 1/distance;
                float intensity = length(_LightColor0.xyz);
                return float4(atten.xxx*intensity * lerp(0,1,atten-0.05),1);
            }
            ENDCG
        }
    }
    Fallback "Standard"

}
