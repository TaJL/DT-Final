using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TalkativePlayer : AoeDetector<Npc> {
  TheInput input;

  void Awake () {
    InputManager.input.WorldActions.Talk.started += ctx => Talk();
  }

  public override void Undetect (Npc old) {
    old.Stop();
  }

  public override void Detect () {
    target.IndicateActiveForTalk();
  }

  public void Talk () {
    if (target && !PlayerDecisions.isActive) {
      target.Speak();
    }
  }
}
