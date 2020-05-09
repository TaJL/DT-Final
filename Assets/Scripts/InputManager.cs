using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class InputManager : NonPersistantSingleton<InputManager> {
  public static TheInput input;

  public override void CustomAwake () {
    input = new TheInput();
    input.WorldActions.Enable();
  }

  public static void SetActive (InputActionMap action, bool value) {
    if (value) action.Enable();
    else action.Disable();
  }
}
