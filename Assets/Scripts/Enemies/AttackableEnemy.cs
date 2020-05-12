using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackableEnemy : Attackable {
  public AudioClip damageSound;
  public AudioSource _speaker;

  void OnEnable () {
    _speaker = GetComponentInParent<AudioSource>();
  }

  public override bool MakeDamage (int damage, Vector3 source, float push) {
    _speaker.volume = Random.Range(0.7f, 1);
    _speaker.pitch = Random.Range(0.8f, 1.2f);
    _speaker.PlayOneShot(damageSound);
    return base.MakeDamage(damage, source, push);
  }
}
