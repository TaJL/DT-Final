using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Platform : MonoBehaviour {
  public Builder visual;
  public bool visible = false;

  void Reset () {
    visual = GetComponentInChildren<Builder>();
  }

  void OnEnable () {
    if (!visible) visual.Hide();
  }
}
