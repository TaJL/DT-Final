using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChoiceOnDialogue : MonoBehaviour {
  public Npc npc;
  public Decision requiredDecision;
  public Road[] choices;

  void Reset () {
    npc = GetComponent<Npc>();
  }

  void OnEnable () {
    npc.onDecisionGiven += HandleDecision;
  }

  public void HandleDecision (Decision decision) {
    if (decision == requiredDecision) {
      foreach (Road choice in choices) {
        choice.Show();
      }
      Destroy(this);
    }
  }
}
