using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Attackable : MonoBehaviour {
  public event System.Action onDead;
  public event System.Action onDamageTaken;

  public int maxHP;
  public int hp;
  public Cooldown cooldown;
  public Rigidbody body;
  public bool dead = false;

  void Awake () {
    hp = maxHP;
  }

  void Update () {
    cooldown.Update();
  }

  public void MakeDamage (int damage, Vector3 source, float push) {
    if (dead) return;
    if (!cooldown.IsOver) return;
    hp -= damage;
    body.AddForce((transform.position - source).normalized * push, ForceMode.Impulse);
    cooldown.Reset();

    if (hp <= 0) {
      dead = true;
      hp = 0;
      if (onDead != null) onDead();
    } else {
      if (onDamageTaken != null) onDamageTaken();
    }
  }
}
