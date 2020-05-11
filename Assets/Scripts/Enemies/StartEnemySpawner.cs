using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartEnemySpawner : MonoBehaviour {
  public event System.Action onFinished;

  public GameObject enemyPrototype;
  public int[] waves = new int[] { 1, 0, 2, 0};
  public int current = 0;
  public StartEnemySpawner[] synchronized;
  public bool canSpawn = false;

  IEnumerator Start () {
    while (true) {
      canSpawn = false;
      List<Enemy> current = Spawn();

      if (current == null) {
        canSpawn = true;
        if (onFinished != null) onFinished();
        yield break;
      }

      yield return new WaitUntil(() => {
          foreach (Enemy enemy in current) {
            if (enemy && !enemy.hp.dead) {
              return false;
            }
          }
          return true;
        });
      canSpawn = true;

      yield return new WaitUntil(() => {
          foreach (StartEnemySpawner spawner in synchronized) {
            if (!spawner.canSpawn) return false;
          }
          return true;
        });
    }
  }

  public List<Enemy> Spawn () {
    if (current >= waves.Length) return null;

    List<Enemy> spawned = new List<Enemy>();

    for (int i=0; i<waves[current]; i++) {
      Enemy enemy = Instantiate(enemyPrototype).GetComponent<Enemy>();
      enemy.agent.Warp(transform.position);
      spawned.Add(enemy);
    }

    current++;
    return spawned;
  }
}
