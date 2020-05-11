using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine.Rendering;

public class CameraSmoothFollow : NonPersistantSingleton<CameraSmoothFollow> {
  public float smoothTime = 0.3f;
  public Transform target;
  public Vector3 speed;
    
  private CommandBuffer keepDepthTexture;

  private Camera camera;
  private void OnEnable()
  {
     
      if (keepDepthTexture == null) {
          keepDepthTexture = new CommandBuffer();
          keepDepthTexture.name = "Keep MainCamera Depth Texture";
          keepDepthTexture.SetGlobalTexture("_MainCameraDepthTexture", BuiltinRenderTextureType.Depth);
     
          Camera.main.depthTextureMode |= DepthTextureMode.Depth;
          Camera.main.AddCommandBuffer(CameraEvent.BeforeForwardAlpha, keepDepthTexture);
      }

  }
  private void Start()
  {
      camera = Camera.main;
      camera.depthTextureMode= Camera.main.depthTextureMode | DepthTextureMode.Depth;
  }

  void FixedUpdate () {
      print(Vector3.Distance(transform.position,camera.transform.position));
    transform.position = Vector3.SmoothDamp(transform.position, target.position,
                                            ref speed, smoothTime);
  }

  public void Shake(float amount, float time)
  {
      IEnumerator Coroutine()
      {
          //Time.timeScale = 0;

          while (time > 0)
          {
              transform.position += Quaternion.AngleAxis(Random.Range(0, 360), transform.forward) * transform.right *
                                    amount;
              time -= Time.deltaTime;
              //Time.timeScale = 1-time;

              yield return null;
          }
      }

      StartCoroutine(Coroutine());
  }
  
  public void SlowTime(float amount, float time)
  {
      IEnumerator Coroutine()
      {
          var start = amount;
          var end = Time.timeScale;
          Time.timeScale = amount;
          var counter = 0f;

          while (counter < 1)
          {
              counter = Mathf.Clamp01(counter + Time.unscaledDeltaTime / time);
              Time.timeScale = Mathf.Lerp(start,end,counter); 
              yield return null;
          }
      }
      StartCoroutine(Coroutine());
  }

  public void Freeze(float seconds)
  {
      IEnumerator Coroutine()
      {
          Time.timeScale = 0;
          while (seconds > 0)
          {
              seconds -= Time.unscaledDeltaTime;
              yield return null;
          }
          Time.timeScale = 1;
      }
      StartCoroutine(Coroutine());
  }
}
