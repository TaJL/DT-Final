using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DecideOnDestroy : MonoBehaviour {
  public Road decission;
  public Enemy destroy;

  void OnEnable () {
    destroy.onDestroyed += Trigger;
  }

  public void Trigger () {
    decission.Show();
  }
}
