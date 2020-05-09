using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class ConditionalKeyMapping : MonoBehaviour {
  public Sprite keyboard;
  public Sprite gamepad;
  public Image placeholder;

  void Awake () {
    InputSystem.onDeviceChange += (device, change) => {
      if (change == InputDeviceChange.Removed) {
        placeholder.sprite = keyboard;
      } else if (change == InputDeviceChange.Added) {
        placeholder.sprite = gamepad;
      }
    };

    placeholder.sprite =
      Gamepad.all.Count() == 0? keyboard: gamepad;
  }
}
