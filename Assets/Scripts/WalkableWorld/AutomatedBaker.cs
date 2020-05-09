using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.AI;
#endif
using System.Collections;
using System.Collections.Generic;

public class AutomatedBaker : MonoBehaviour {
  #if UNITY_EDITOR
  // expensive modafoka
  public void Bake () {
    foreach (NavMeshBakeable bakeable in GameObject.FindObjectsOfType<NavMeshBakeable>()) {
      bakeable.SetStatic(true);
    }
    NavMeshBuilder.BuildNavMesh();
    foreach (NavMeshBakeable bakeable in GameObject.FindObjectsOfType<NavMeshBakeable>()) {
      bakeable.SetStatic(false);
    }
  }
  #endif
}
