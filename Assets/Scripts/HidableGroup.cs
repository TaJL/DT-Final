using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HidableGroup : MonoBehaviour {
  public bool isVisible = false;

  void Awake () {
    SetVisibility(isVisible, true);
  }

  public void SetVisibility (bool value, bool instantly = false) {
    isVisible = value;
    foreach (Hidable hidable in GetComponentsInChildren<Hidable>()) {
      if (instantly) {
        hidable.SetInstantlyVisibility(value);
      } else {
        hidable.SetVisibility(value);
      }
    }
  }
}
