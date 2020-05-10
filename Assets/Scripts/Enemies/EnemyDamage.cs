using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyDamage : MonoBehaviour {
  public float pushForce = 2.5f;

  void OnTriggerEnter (Collider c) {
    Attackable attackable = c.GetComponent<AttackablePlayer>();

    if (attackable) {
      attackable.MakeDamage(1, transform.position, pushForce);
    }
  }
}
