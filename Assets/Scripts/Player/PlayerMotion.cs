using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMotion : MonoBehaviour {
  public float speed = 8;
  public Vector3 direction;

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
      transform.forward = direction;
    }

    transform.position += direction * speed * Time.deltaTime;
  }
}
