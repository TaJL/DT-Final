using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAnimations : MonoBehaviour {
  public PlayerMotion motion;
  public Animator animator;
  public Attackable hp;
  public ParticleSystem attackedFeedback;
  public Shield shield;

  void OnEnable () {
    GetComponentInChildren<Sword>().onAttack += AttackAnimation;
    hp = GetComponentInChildren<Attackable>();
    hp.onDamageTaken += TakeDamageAnimation;
    hp.onDead += HandleDead;
  }

  void OnDisable () {
    if (GetComponentInChildren<Sword>()) {
      GetComponentInChildren<Sword>().onAttack -= AttackAnimation;
    }
    hp.onDamageTaken -= TakeDamageAnimation;
    hp.onDead -= HandleDead;
  }

  public void HandleDead () {
    animator.SetTrigger("die");
  }

  public void AttackAnimation () {
    animator.SetTrigger("attack");
  }

  public void TakeDamageAnimation () {
    Mixer.Instance.TweenCutOff(50,0f,2);
    CameraSmoothFollow.Instance.SlowTime(0,2f);
    attackedFeedback.Play();
  }

  void Update () {
    if (motion.enabled) {
      animator.SetFloat("speed", motion.smoothedMotion.magnitude);
    } else {
      animator.SetFloat("speed", 0);
    }
    animator.SetBool("in pain", !hp.cooldown.IsOver);
    animator.SetBool("shielded", shield.isActive);
  }
}
