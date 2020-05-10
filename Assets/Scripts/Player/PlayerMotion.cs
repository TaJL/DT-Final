using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMotion : MonoBehaviour {
  public float speed = 8;
  public Vector3 direction;
  public Vector3 directionLerped = new Vector3();

  void Awake () {
    Transform viewport = Camera.main.transform.parent;

    InputManager.input.WorldActions.Move.performed +=
      (ctx => {
        Vector2 value = ctx.ReadValue<Vector2>();
        if (value.magnitude < 0.2f) {
          direction = Vector3.zero;
        } else {
          direction = ctx.ReadValue<Vector2>();
          direction = viewport.right * direction.x +
            viewport.forward * direction.y;
        }
      });
  }

  void FixedUpdate () {
    if (direction.magnitude > 0.2f) {
      transform.forward = Vector3.Lerp(transform.forward, direction, 0.8f);
    }
        directionLerped = Vector3.Lerp(directionLerped, direction, 0.8f);
    transform.position += directionLerped * speed * Time.deltaTime;
  }
}
