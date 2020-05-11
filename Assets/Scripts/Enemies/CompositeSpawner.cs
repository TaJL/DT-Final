using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CompositeSpawner : MonoBehaviour {
  public event System.Action onFinished;

  public StartEnemySpawner[] spawners;
  public int finished = 0;

  void Awake () {
    foreach (StartEnemySpawner spawner in spawners) {
      spawner.onFinished += Count;
    }
  }

  public void Count () {
    finished++;
    if (finished == spawners.Length && onFinished != null) onFinished();
  }
}
