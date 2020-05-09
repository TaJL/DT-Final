using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraSmoothFollow : MonoBehaviour {
  public float smoothTime = 0.3f;
  public Transform target;
  public Vector3 speed;

  void FixedUpdate () {
    transform.position = Vector3.SmoothDamp(transform.position, target.position,
                                            ref speed, smoothTime);
  }
}
