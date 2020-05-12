using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MusicDimmer : MonoBehaviour {
  public SmoothedVolume speaker;
  public float inside = 1;
  public float outside = 0.3f;
  public float insideTime = 1;
  public float outsideTime = 3;

  public AudioClip ambient;
  public AudioClip theme;

  void OnTriggerEnter (Collider c) {
    if (Time.time < 1) return;
    if (c.GetComponent<AttackablePlayer>()) {
      speaker.ResetEvents();
      speaker.target = 0;
      speaker.time = insideTime;
      speaker.onVolumeZero += ToTheme;
    }
  }

  void OnTriggerExit (Collider c) {
    if (c.GetComponent<AttackablePlayer>()) {
      speaker.target = 0;
      speaker.time = outsideTime;
      speaker.onVolumeZero += ToAmbient;
    }
  }

  public void ToTheme () {
    speaker.onVolumeZero -= ToTheme;
    speaker.speaker.clip = theme;
    speaker.speaker.Play();
    speaker.target = inside;
    speaker.time = outsideTime * 1.5f;
  }

  public void ToAmbient () {
    speaker.onVolumeZero -= ToAmbient;
    speaker.speaker.clip = ambient;
    speaker.speaker.Play();
    speaker.target = outside;
  }
}
