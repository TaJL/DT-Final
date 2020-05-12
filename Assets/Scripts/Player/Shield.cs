using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shield : MonoBehaviour {
  public Sword sword;
  public Gun gun;
  public bool isActive;
  public ParticleSystem hitEffect;
  public GameObject model;
  public bool usingShield = false;
  public PlayerMotion motion;
  public float angle = 120;

  Coroutine _shield;

  void OnEnable () {
    InputManager.input.WorldActions.Shield.started += ctx => usingShield = true;
    InputManager.input.WorldActions.Shield.started += ctx => Activate();
    InputManager.input.WorldActions.Shield.canceled += ctx => usingShield = false;
    sword.onAttack += Stop;
  }

  public void Stop () {
    usingShield = false;
  }

  public void Activate () {
    if (_shield == null && !gun.shooting) {
      _shield = StartCoroutine(_Activate());
    }
  }

  public void Hit (Vector3 direction) {
    hitEffect.Play();
    hitEffect.transform.forward = direction;
  }

  IEnumerator _Activate () {
    model.SetActive(true);
    isActive = true;

    float elapsed = 0;
    while (elapsed < 0.1f) {
      yield return null;
      elapsed += Time.deltaTime;
      motion.transform.forward = motion.attackDirection;
    }
    motion.enabled = false;

    yield return new WaitUntil(() => !usingShield);

    isActive = false;
    model.SetActive(false);

    yield return new WaitForSeconds(0.1f);
    motion.enabled = true;
    _shield = null;
  }
}
