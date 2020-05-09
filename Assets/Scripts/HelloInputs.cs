using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelloInputs : MonoBehaviour {
  TheInput input;

  void Awake () {
    input = new TheInput();
    input.Decission.North.started += ctx => Zomgz();
  }

  void OnEnable () {
    input.Decission.Enable();
  }

  public void Zomgz () {
    Debug.Log("zomgz! " + Time.time);
  }
}
