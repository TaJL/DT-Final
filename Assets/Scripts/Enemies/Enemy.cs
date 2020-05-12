using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {
  public event System.Action onDestroyed;

  public AttackableEnemy hp;
  public Animator animator;
  public FollowAndAttack behaviour;
  public NavMeshAgent agent;
  public bool destroyOnOver = false;

  void OnEnable () {
    hp.onDead += Die;
  }

  public void Die () {
    Destroy(behaviour);
    animator.SetTrigger("die");
    Destroy(agent);
    Destroy(hp);

    if (destroyOnOver) {
      DestroyForOnce();
    }
  }

  public void DestroyForOnce () {
    StartCoroutine(_Destroy());
    if (onDestroyed != null) onDestroyed();
  }

  IEnumerator _Destroy () {
    yield return new WaitForSeconds(Random.Range(0.5f, 1f));
    float elapsed = 0;
    while (elapsed <= 2) {
      elapsed += Time.deltaTime;
      transform.Translate(0, -Time.deltaTime * 1, 0);
      yield return null;
    }
    Destroy(gameObject);
  }
}
