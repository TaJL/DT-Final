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
  public AudioClip charge;
  public AudioClip attack;

  Coroutine _attack;
  Coroutine _chase;
  AudioSource _speaker;

  void OnEnable () {
    _speaker = GetComponent<AudioSource>();
  }

  private float cooldown = 0;

  void Update ()
  {
    if (cooldown > 0)
    {
      cooldown -= Time.deltaTime;
      return;
    }

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
    Transform target = far.target.transform;
    while (true) {
      agent.SetDestination(target.position);
      yield return new WaitForSeconds(Random.Range(repathTime.x, repathTime.y));
    }
  }

  public void ResetBehaviour()
  {
    StopAllCoroutines();
    animator.SetTrigger("reset");
    _attack = null;
    _chase = null;
    state = ChaserState.Idle;
    cooldown = 1f;
    damage.enabled = false;
  }
  IEnumerator _Attack () {
    Sfx.Instance.speaker.volume = Random.Range(0.1f, 0.3f);
    Sfx.Instance.speaker.pitch = Random.Range(0.7f, 1.2f);
    Sfx.Instance.speaker.PlayOneShot(charge);
    // Sfx.Instance.speaker.volume = Sfx.Instance.speaker.pitch = 1;

    agent.ResetPath();
    animator.SetTrigger("reset");
    Vector3 target = close.target.transform.position;
    animator.SetTrigger("attack step");
    transform.LookAt(target);
    transform.forward = Vector3.Scale(new Vector3(1,0,1), transform.forward);

    float elapsed = 0;
    while (elapsed < chargingTime/2f) {
      elapsed += Time.deltaTime;
      target = close.target? close.target.transform.position: target;
      transform.LookAt(target);
      transform.forward = Vector3.Scale(new Vector3(1,0,1), transform.forward);
      yield return null;
    }

    yield return new WaitForSeconds(chargingTime/2f);

    Sfx.Instance.speaker.volume = Random.Range(0.1f, 0.3f);
    Sfx.Instance.speaker.pitch = Random.Range(0.7f, 1.2f);
    Sfx.Instance.speaker.PlayOneShot(attack);
    // Sfx.Instance.speaker.volume = Sfx.Instance.speaker.pitch = 1;

    animator.SetTrigger("attack step");
    damage.enabled = true;
    elapsed = 0;
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
