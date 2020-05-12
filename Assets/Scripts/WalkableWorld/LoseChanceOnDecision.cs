using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoseChanceOnDecision : MonoBehaviour {
  public Road chanceLost;
  public Road decisionTaken;

  void OnEnable () {
    decisionTaken.onDecisionTaken += LoseChance;
  }

  void OnDisable () {
    decisionTaken.onDecisionTaken -= LoseChance;
  }

  public void LoseChance () {
    chanceLost.Hide(true);
  }
}
