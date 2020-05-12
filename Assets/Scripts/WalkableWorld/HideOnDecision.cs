using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HideOnDecision : MonoBehaviour {
  public Road decisionTaken;
  public Hidable hidable;
  public bool value = false;

  void OnEnable () {
    decisionTaken.onDecisionTaken += Hide;
  }

  void OnDisable () {
    decisionTaken.onDecisionTaken -= Hide;
  }

  public void Hide () {
    hidable.SetVisibility(value);
  }
}
