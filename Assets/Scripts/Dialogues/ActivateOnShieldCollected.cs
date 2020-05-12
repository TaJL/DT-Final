using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActivateOnShieldCollected : MonoBehaviour {
  public GameObject target;
  public bool value;

  void Awake () {
    CollectableShield.onCollected += Trigger;
  }

  void OnDestroy () {
    CollectableShield.onCollected -= Trigger;
  }

  public void Trigger () {
    target.SetActive(value);
  }
}
