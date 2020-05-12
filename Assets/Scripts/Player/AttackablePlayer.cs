using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackablePlayer : Attackable {
  public Shield shield;

  public override bool MakeDamage (int damage, Vector3 source, float push) {
    if (!CanTakeDamage) return false;

    if (!shield || shield.gameObject.activeSelf == false || !shield.isActive) {
      base.MakeDamage(damage, source, push);
      return true;
    } else {
      if (shield.isActive &&
          Vector3.Angle(transform.forward, source - transform.position) > shield.angle) {
        base.MakeDamage(damage, source, push);
        return true;
      } else {
        shield.Hit(source - transform.position);
        Push(source, push);
      }
    }

    return false;
  }
}
