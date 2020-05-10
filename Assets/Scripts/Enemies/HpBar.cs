using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HpBar : MonoBehaviour {
  public AttackableEnemy attackable;
  float _original;

  void Awake () {
    _original = transform.localScale.x;
  }

  void Reset () {
    attackable = transform.GetComponentInParent<AttackableEnemy>();
  }

  void Update () {
    transform.localScale =
      Util.SetX(transform.localScale,
                _original * (attackable.hp / (float) attackable.maxHP));
    transform.forward = Camera.main.transform.position - transform.position;
  }
}
