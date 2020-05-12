using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HidableGroup : MonoBehaviour {
  public bool isVisible = false;

  void Awake () {
    SetVisibility(isVisible);
  }

  public void SetVisibility (bool value) {
    isVisible = value;
    foreach (Hidable hidable in GetComponentsInChildren<Hidable>()) {
      hidable.SetVisibility(value);
    }
  }
}
