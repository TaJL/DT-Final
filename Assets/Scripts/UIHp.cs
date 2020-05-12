using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UIHp : MonoBehaviour {
  public Image image;
  public Animator animator;
  AttackablePlayer _hp;

  void OnEnable () {
    _hp = GameObject.FindWithTag("Player").GetComponentInChildren<AttackablePlayer>();
    _hp.onDamageTaken += HandleDamage;
  }

  void Reset () {
    image = GetComponent<Image>();
    animator = GetComponent<Animator>();
  }

  public void HandleDamage () {
    if ((_hp.hp - 1) == transform.GetSiblingIndex()) {
      animator.SetTrigger("hit");
    }
  }
}
