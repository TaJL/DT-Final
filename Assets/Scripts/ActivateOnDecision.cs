using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActivateOnDecision : MonoBehaviour {
  public Road decisionTaken;
  public GameObject toActivate;
  public bool value;

  void OnEnable () {
    decisionTaken.onDecisionTaken += Hide;
  }

  void OnDisable () {
    decisionTaken.onDecisionTaken -= Hide;
  }

  public void Hide () {
    toActivate.SetActive(value);
  }
}
