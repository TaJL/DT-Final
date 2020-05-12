using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SmoothedVolume : MonoBehaviour {
  public AudioSource speaker;
  public float target;
  public float speed;
  public float time = 3;

  void Reset () {
    speaker = GetComponent<AudioSource>();
  }

  void Update () {
    speaker.volume = Mathf.SmoothDamp(speaker.volume, target, ref speed, time);
  }
}
