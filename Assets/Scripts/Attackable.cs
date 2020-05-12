using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Attackable : MonoBehaviour {
  public event System.Action onDead;
  public event System.Action onDamageTaken;
  public event System.Action onHealed;

  public bool IsFull { get => hp >= maxHP; }
  public bool invulnerable = false;
  public bool CanTakeDamage { get => !dead && cooldown.IsOver; }
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

  public void Heal () {
    hp = maxHP;
    if (onHealed != null) onHealed();
  }

  public void Push (Vector3 source, float push) {
    body.AddForce((transform.position - source).normalized * push, ForceMode.Impulse);
  }

  public virtual bool MakeDamage (int damage, Vector3 source, float push) {
    if (!CanTakeDamage) return false;
    if (invulnerable) return false;

    hp -= damage;
    Push(source, push);
    cooldown.Reset();

    if (hp <= 0) {
      dead = true;
      hp = 0;
      if (onDead != null) onDead();
    } else {
      if (onDamageTaken != null) onDamageTaken();
    }

    return true;
  }
}
