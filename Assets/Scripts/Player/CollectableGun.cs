using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectableGun : MonoBehaviour {
  public static event System.Action onCollected;

  void OnTriggerEnter (Collider c) {
    WeaponsManager manager = c.GetComponentInParent<WeaponsManager>();
    if (manager) {
      manager.CollectGun();
      transform.parent.gameObject.SetActive(false);
      if (onCollected != null) onCollected();
    }
  }
}
