using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[CustomEditor(typeof(Road))]
[CanEditMultipleObjects]
public class RoadEditor : Editor {
  Road Target { get => (Road) target; }

  public override void OnInspectorGUI () {
    DrawDefaultInspector();
    if (GUILayout.Button("chose")) {
      Target.Show();
    }
  }
}
