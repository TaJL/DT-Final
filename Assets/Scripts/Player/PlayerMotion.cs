using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class PlayerMotion : MonoBehaviour {
  public float speed = 8;
  public Vector3 direction;
  public Vector3 directionLerped = new Vector3();
  private Transform viewport;
  void Awake () {
    viewport = Camera.main.transform.parent;
    /*InputManager.input.WorldActions.Move.performed +=
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
      */
  }

  void FixedUpdate () {
    if (direction.magnitude > 0.2f) {
      transform.forward = Vector3.Lerp(transform.forward, direction, 0.8f);
    }
    //print(InputManager.input.WorldActions.VerticalAxis.ReadValue<float>());
    var vertical = InputManager.input.WorldActions.VerticalAxis.ReadValue<float>();
    var horizontal = InputManager.input.WorldActions.HorizontalAxis.ReadValue<float>();
    var dir = (viewport.right * horizontal + viewport.forward * vertical);
        directionLerped = Vector3.Lerp(directionLerped, dir, 0.8f);
        transform.forward = dir;
    transform.position += dir * speed * Time.deltaTime;
  }
}
