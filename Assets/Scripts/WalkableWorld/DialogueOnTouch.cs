using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueOnTouch : MonoBehaviour {
  public Npc dialogue;
  bool _done = false;

  void OnTriggerEnter (Collider c) {
    if (_done) return;

    if (c.GetComponentInParent<Player>() && !NpcDialoguePlaceholder.Instance.IsVisible) {
      dialogue.Speak();
      _done = true;
      Destroy(this);
    }
  }
}
