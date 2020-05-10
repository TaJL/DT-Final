using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : NonPersistantSingleton<Player> {
  public TalkativePlayer dialogues;
  public PlayerMotion motion;
  public Sword sword;

  void OnEnable () {
    GetComponentInChildren<Attackable>().onDead += HandleDeath;
  }

  void Reset () {
    dialogues = GetComponentInChildren<TalkativePlayer>();
    sword = GetComponentInChildren<Sword>();
    motion = GetComponent<PlayerMotion>();
    dialogues = GetComponent<TalkativePlayer>();
  }

  public void HandleDeath () {
    Destroy(motion);
    Destroy(dialogues);
    Destroy(sword.gameObject);
  }
}
