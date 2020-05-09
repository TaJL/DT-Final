using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Sword : MonoBehaviour {
  public ParticleSystem trail;
  public float angle = 50;
  public float duration = 0.25f;
  public int damage;
  public Cooldown attack;
  public PlayerMotion motion;
  public float afterAttackRecovery = 0.2f;
  public float chargeSpeedMultiplier = 5;
  public float pushForce = 5;
  public Collider damageAoe;

  Coroutine _attack;

  void OnEnable () {
    InputManager.input.WorldActions.MeleeAttack.started += ctx => Attack();
    transform.Rotate(0, angle, 0);
  }

  void OnTriggerEnter (Collider c) {
    AttackableEnemy attackable = c.GetComponent<AttackableEnemy>();
    if (attackable) {
      Debug.Log(c, c);
      attackable.MakeDamage(damage, transform.position, pushForce);
    }
  }

  void Update () {
    attack.Update();
  }

  public void Attack () {
    if (!attack.IsOver) return;
    if (_attack != null) return;
    _attack = StartCoroutine(_Attack());
  }

  IEnumerator _Attack () {
    float elapsed = 0;
    float direction = (transform.localRotation.eulerAngles.y < 0 ||
                       transform.localRotation.eulerAngles.y > 180? 1: -1);
    trail.Play();
    damageAoe.enabled = true;

    float speedMultiplier = 1;
    do {
      if (elapsed > 0.1f) {
        motion.enabled = false;
      }
      elapsed += Time.deltaTime;
      transform.localRotation =
        Quaternion.Euler(0, Mathf.Lerp(-direction * angle, direction * angle,
                                       elapsed / duration), 0);
      motion.transform.position += (motion.transform.forward * Time.deltaTime *
                                    motion.speed * chargeSpeedMultiplier * speedMultiplier);
      speedMultiplier = 1 - elapsed / duration;
      yield return null;
    } while (elapsed < duration);
    damageAoe.enabled = true;

    yield return new WaitForSeconds(afterAttackRecovery);

    motion.enabled = true;
    trail.Stop();
    _attack = null;
  }
}
