using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackableEnemy : MonoBehaviour {
  public int hp;
  public Cooldown cooldown;
  public Rigidbody body;

  void Update () {
    cooldown.Update();
  }

  public void MakeDamage (int damage, Vector3 source, float push) {
    if (!cooldown.IsOver) return;
    hp -= damage;
    body.AddForce((transform.position - source).normalized * push, ForceMode.Impulse);
    cooldown.Reset();
  }
}
