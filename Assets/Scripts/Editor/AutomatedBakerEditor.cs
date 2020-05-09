using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[CustomEditor(typeof(AutomatedBaker))]
public class AutomatedBakerEditor : Editor {
  AutomatedBaker Target { get => (AutomatedBaker) target; }

  public override void OnInspectorGUI () {
    DrawDefaultInspector();
    if (GUILayout.Button("BAKE!")) {
      Target.Bake();
    }
  }
}
