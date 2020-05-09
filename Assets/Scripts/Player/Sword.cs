using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Sword : MonoBehaviour {
  public ParticleSystem trail;
  public float angle = 50;
  public float duration = 0.25f;
  Coroutine _attack;

  void OnEnable () {
    InputManager.input.WorldActions.MeleeAttack.started += ctx => Attack();
    transform.Rotate(0, angle, 0);
  }

  public void Attack () {
    if (_attack != null) return;
    _attack = StartCoroutine(_Attack());
  }

  IEnumerator _Attack () {
    float elapsed = 0;
    float direction = (transform.localRotation.eulerAngles.y < 0 ||
                       transform.localRotation.eulerAngles.y > 180? 1: -1);
    trail.Play();
    
    do {
      elapsed += Time.deltaTime;
      transform.localRotation =
        Quaternion.Euler(0, Mathf.Lerp(-direction * angle, direction * angle,
                                       elapsed / duration), 0);
      yield return null;
    } while (elapsed < duration);

    
    trail.Stop();
    _attack = null;
  }
}
