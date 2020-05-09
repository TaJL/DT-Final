using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChoiceOnTouch : MonoBehaviour {
  public Road[] choices;

  void OnTriggerEnter (Collider c) {
    if (c.gameObject.CompareTag("Player")) {
      foreach (Road choice in choices) {
        choice.Show();
      }
      Destroy(this);
    }
  }
}
