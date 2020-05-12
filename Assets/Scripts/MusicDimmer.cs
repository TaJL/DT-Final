using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MusicDimmer : MonoBehaviour {
  public SmoothedVolume speaker;
  public float inside = 1;
  public float outside = 0.3f;
  public float insideTime = 1;
  public float outsideTime = 3;

  void OnTriggerEnter (Collider c) {
    if (c.GetComponent<AttackablePlayer>()) {
      speaker.target = inside;
      speaker.time = insideTime;
    }
  }

  void OnTriggerExit (Collider c) {
    if (c.GetComponent<AttackablePlayer>()) {
      speaker.target = outside;
      speaker.time = outsideTime;
    }
  }
}
