using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActivateOnDialogueOver : MonoBehaviour {
  public Npc dialogue;
  public GameObject target;
  public bool value;

  void Awake () {
    dialogue.onTalkingFinished += Trigger;
  }

  void OnDestroy () {
    if (dialogue) dialogue.onTalkingFinished -= Trigger;
  }

  public void Trigger () {
    target.SetActive(value);
  }
}
