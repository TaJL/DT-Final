using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Fruit : MonoBehaviour {
  public ParticleSystem effect;
  bool eaten = false;

  void OnTriggerEnter (Collider c) {
    if (eaten) return;

    AttackablePlayer attackable = c.GetComponent<AttackablePlayer>();
    if (attackable && !attackable.IsFull) {
      attackable.Heal();
      eaten = true;
      effect.transform.parent = null;
      effect.Play();
      Destroy(this.gameObject);
    }
  }
}
