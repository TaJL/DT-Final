using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NavMeshBakeable : MonoBehaviour {
  #if UNITY_EDITOR
  public void SetStatic (bool value) {
    gameObject.isStatic = value;
    foreach (Transform child in transform) {
      child.gameObject.isStatic = value;
    }
  }
  #endif
}
