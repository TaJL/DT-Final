using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hidable : MonoBehaviour {
  public Animator animator;

  void Reset () {
    animator = GetComponent<Animator>();
  }

  void OnEnable () {
    animator.SetBool("is visible", true);
  }
}
