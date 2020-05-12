using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HideOnDialogueOver : MonoBehaviour {
  public Npc dialogue;
  public HidableGroup target;
  public bool value;

  void Awake () {
    dialogue.onTalkingFinished += Trigger;
  }

  void OnDestroy () {
    if (dialogue) dialogue.onTalkingFinished -= Trigger;
  }

  public void Trigger () {
    target.SetVisibility(value);
  }
}
