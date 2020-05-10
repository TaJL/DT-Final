using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMotion : MonoBehaviour {
  public float speed = 8;
  public Vector3 attackDirection;
  public Vector3 direction;
  public Vector3 smoothedMotion;
  public Vector3 smoothedDirection;
  public float motionSmoothSpeed = 5;
  public float directionSmoothSpeed = 5;

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
    smoothedDirection = attackDirection = transform.forward;
  }

  void FixedUpdate () {
    if (direction.magnitude > 0.2f) { // uso intencional de direction
      attackDirection = direction;
      // transform.position += direction * speed * Time.deltaTime;
      // transform.forward = direction;
    }

    smoothedDirection =
      Vector3.RotateTowards(smoothedDirection, attackDirection,
                            directionSmoothSpeed * Time.deltaTime, 1);

    transform.forward = smoothedDirection;

    smoothedMotion =
      Vector3.MoveTowards(smoothedMotion, direction,
                          motionSmoothSpeed * Time.deltaTime);

    transform.position += smoothedMotion * speed * Time.deltaTime;
  }
}
