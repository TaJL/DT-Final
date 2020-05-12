using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackableEnemy : Attackable {
  public AudioClip damageSound;
  public AudioSource _speaker;

  public override bool MakeDamage (int damage, Vector3 source, float push) {
    _speaker.volume = Random.Range(0.05f, 0.1f);
    _speaker.pitch = Random.Range(0.8f, 1.2f);
    _speaker.PlayOneShot(damageSound);
    return base.MakeDamage(damage, source, push);
  }
}
