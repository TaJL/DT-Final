using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyOnDecision : MonoBehaviour {
  public Decision decision;
  public Npc npc;
  public Enemy destroy;

  void OnEnable () {
    npc.onDecisionGiven += Trigger;
  }

  public void Trigger (Decision decided) {
    if (decided == decision) {
      destroy.DestroyForOnce();
    }
  }
}
