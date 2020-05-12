using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TheEvilSide : MonoBehaviour {
  public AttackableEnemy attackable;
  public GameObject detector;
  public Npc dialogue;

  void OnEnable () {
    dialogue.onTalkingFinished += BecomeABoss;
  }

  void OnDisable () {
    dialogue.onTalkingFinished -= BecomeABoss;
  }

  public void BecomeABoss () {
    attackable.invulnerable = false;
    detector.SetActive(true);
  }
}
