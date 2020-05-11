using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[CustomEditor(typeof(Builder))]
[CanEditMultipleObjects]
public class BuilderEditor : Editor {
  Builder Target { get => (Builder) target; }
  
  public override void OnInspectorGUI () {
    DrawDefaultInspector();
    if (GUILayout.Button("build!")) {
      Target.Show();
    }
  }
}
