using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectableShield : MonoBehaviour {
  public static event System.Action onCollected;

  void OnTriggerEnter (Collider c) {
    WeaponsManager manager = c.GetComponentInParent<WeaponsManager>();
    if (manager) {
      manager.CollectShield();
      gameObject.SetActive(false);
      if (onCollected != null) onCollected();
    }
  }
}
