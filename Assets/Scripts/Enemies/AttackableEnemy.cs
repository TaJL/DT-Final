using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackableEnemy : Attackable {
  public AudioClip damageSound;
  public AudioSource _speaker;
  bool _marked = false;

  public override bool MakeDamage (int damage, Vector3 source, float push) {
    _speaker.volume = Random.Range(0.05f, 0.1f);
    _speaker.pitch = Random.Range(0.8f, 1.2f);
    _speaker.PlayOneShot(damageSound);

    if (!_marked) {
      _marked = true;
      GetComponentInParent<Enemy>().GetComponentInChildren<FollowAndAttack>().target =
        Player.Instance;
    }

    return base.MakeDamage(damage, source, push);

  }
}
