using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DropFruitOnHordeOver : MonoBehaviour {
  public CompositeSpawner spawner;
  public FruitDropper[] dropper;

  void OnEnable () {
    spawner.onFinished += Spawn;
  }

  public void Spawn () {
    foreach (FruitDropper d in dropper) {
      d.DropFruit();
    }
  }
}
