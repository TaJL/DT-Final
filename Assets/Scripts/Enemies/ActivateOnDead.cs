using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActivateOnDead : MonoBehaviour {
  public Attackable attackable;
  public GameObject target;

  void OnEnable () {
    attackable.onDead += Trigger;
  }

  public void Trigger () {
    target.SetActive(true);
  }
}
