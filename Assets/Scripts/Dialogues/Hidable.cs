using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hidable : MonoBehaviour {
  public Tween tweener; 
  public bool value;

  void OnEnable () {
    if (!GetComponentInParent<HidableGroup>()) {
      SetInstantlyVisibility(value);
    }
  }

  public void SetInstantlyVisibility (bool value) {
    transform.GetChild(0).localScale = value? Vector3.one: Vector3.zero;
  }

  public void SetVisibility (bool value) {
    tweener.TweenTo(transform.GetChild(0),null,null,value?Vector3.one:Vector3.zero);
  }
}
