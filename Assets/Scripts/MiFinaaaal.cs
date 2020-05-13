using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MiFinaaaal : MonoBehaviour {
  public int que;
  public bool t = false;

  void OnTriggerEnter(Collider c) {
    if (t) return;
    if (c.GetComponentInParent<Player>()) {
      t = true;
      StartCoroutine(_Trigger());
    }
  }

  IEnumerator _Trigger () {
    yield return new WaitForSeconds(2);
    switch (que) {
      case 0: FinaleCountHandler.Instance.FinalMaldad(); break;
      case 1: FinaleCountHandler.Instance.FinalBalance(); break;
      case 2: FinaleCountHandler.Instance.FinalMoralRota(); break;
    }
  }
}
