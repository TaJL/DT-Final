using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAnimations : MonoBehaviour {
  public PlayerMotion motion;
  public Animator animator;
  public Attackable hp;
  public ParticleSystem attackedFeedback;

  void OnEnable () {
    GetComponentInChildren<Sword>().onAttack += AttackAnimation;
    hp = GetComponentInChildren<Attackable>();
    hp.onDamageTaken += TakeDamageAnimation;
  }

  public void AttackAnimation () {
    animator.SetTrigger("attack");
  }

  public void TakeDamageAnimation () {
    attackedFeedback.Play();
  }

  void Update () {
    animator.SetFloat("speed", motion.smoothedMotion.magnitude);
    animator.SetBool("in pain", !hp.cooldown.IsOver);
  }
}
