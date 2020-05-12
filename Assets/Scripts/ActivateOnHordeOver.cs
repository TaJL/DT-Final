using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActivateOnHordeOver : MonoBehaviour {
  public CompositeSpawner spawner;
  public GameObject target;
  public bool value;

  void Awake () {
    spawner.onFinished += Trigger;
  }

  public void Trigger () {
    target.SetActive(value);
  }
}
