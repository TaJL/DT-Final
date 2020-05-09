using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Builder : MonoBehaviour {
  public Vector2 waitingTime = new Vector2(0, 0.5f);
  public Vector2 speedRange = new Vector2(20, 30);

  public void Hide () {
    foreach (Transform child in transform) {
      child.transform.position = Util.SetY(child.transform.position, Bottom.PosY);
    }
  }

  public void Show () {
    foreach (Transform child in transform) {
      StartCoroutine(_PopItTo(child, transform.position.y));
    }
  }

  IEnumerator _PopItTo (Transform thing, float y) {
    yield return new WaitForSeconds(Random.Range(waitingTime.x, waitingTime.y));
    Vector3 target = Util.SetY(thing.position, y);
    float speed = Random.Range(speedRange.x, speedRange.y);

    while (thing.position.y != y) {
      thing.position = Vector3.MoveTowards(thing.position, target,
                                           Mathf.SmoothStep(0,1,speed * Time.deltaTime));
      yield return null;
    }
  }
}
