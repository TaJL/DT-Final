using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hidable : MonoBehaviour {
  public Animator animator;

  void Reset () {
    animator = GetComponent<Animator>();
  }

  public void SetVisibility (bool value) {
    animator.SetBool("is visible", value);
  }
}
