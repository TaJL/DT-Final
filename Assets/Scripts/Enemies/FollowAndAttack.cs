using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class FollowAndAttack : MonoBehaviour {
  public ChaserState state;

  public float chargingTime = 1;
  public float dashAttackSpeed = 20;
  public float recoveryTime = 1;
  public float dashingTime = 0.5f;

  public NavMeshAgent agent;
  public PlayerDetector far;
  public PlayerDetector close;
  public Vector2 repathTime = new Vector2(0.2f, 0.5f);
  public Animator animator;
  public Transform motionTarget;
  public Collider damage;

  Coroutine _attack;
  Coroutine _chase;

  void Update () {
    animator.SetFloat("speed", agent.velocity.magnitude);

    if ((far.target && !close.target) && _chase == null && _attack == null) {
      if (_attack != null) {
        StopCoroutine(_attack);
        _attack = null;
      }
      _chase = StartCoroutine(_Chase());
      state = ChaserState.Chasing;
    } else if (close.target && _attack == null) {
      if (_chase != null) {
        StopCoroutine(_chase);
        _chase = null;
      }
      _attack = StartCoroutine(_Attack());
      state = ChaserState.Attacking;
    }
  }

  IEnumerator _Chase () {
    animator.SetTrigger("reset");
    while (true) {
      agent.SetDestination(far.target.transform.position);
      yield return new WaitForSeconds(Random.Range(repathTime.x, repathTime.y));
    }
  }

  IEnumerator _Attack () {
    agent.ResetPath();
    animator.SetTrigger("reset");
    Vector3 target = close.target.transform.position;
    animator.SetTrigger("attack step");
    transform.LookAt(target);
    transform.forward = Vector3.Scale(new Vector3(1,0,1), transform.forward);

    yield return new WaitForSeconds(chargingTime);

    animator.SetTrigger("attack step");
    damage.enabled = true;
    float elapsed = 0;
    Vector3 direction = (target - motionTarget.position).normalized;
    while (elapsed < dashingTime) {
      motionTarget.position += direction * dashAttackSpeed * Time.deltaTime;
      elapsed += Time.deltaTime;
      yield return null;
    }
    damage.enabled = false;

    animator.SetTrigger("attack step");
    yield return new WaitForSeconds(recoveryTime);

    animator.SetTrigger("reset");
    _attack = null;
  }
}
