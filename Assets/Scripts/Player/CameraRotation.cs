using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraRotation : MonoBehaviour {
  public Vector2 order;
  public float rotationSpeed = 600;

  void OnEnable () {
    InputManager.input.WorldActions.Look.performed += ctx => {
      order = ctx.ReadValue<Vector2>();
    };
  }

  void FixedUpdate () {
    transform.Rotate(0, order.x * Time.deltaTime * rotationSpeed, 0);
  }
}
