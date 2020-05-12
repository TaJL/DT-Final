using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hidable : MonoBehaviour {
  public Animator animator;
  public Tween tweener; 

  void Reset () {
    //animator = GetComponent<Animator>();
  }

  public void SetVisibility (bool value) {
    tweener.TweenTo(transform.GetChild(0),null,null,value?Vector3.one:Vector3.zero);
    //animator.SetBool("is visible", value);
  }
}
