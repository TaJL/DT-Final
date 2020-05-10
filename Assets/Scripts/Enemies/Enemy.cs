using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {
  public AttackableEnemy hp;
  public Animator animator;
  public FollowAndAttack behaviour;
  public NavMeshAgent agent;

  void OnEnable () {
    hp.onDead += Die;
  }

  public void Die () {
    Destroy(behaviour);
    animator.SetTrigger("die");
    StartCoroutine(_Destroy());
    Destroy(agent);
    Destroy(hp.gameObject);
    StartCoroutine(_Destroy());
  }

  IEnumerator _Destroy () {
    yield return new WaitForSeconds(Random.Range(0.5f, 1f));
    float elapsed = 0;
    while (elapsed <= 4) {
      elapsed += Time.deltaTime;
      transform.Translate(0, -Time.deltaTime * 0.2f, 0);
      yield return null;
    }
    Destroy(gameObject);
  }
}
