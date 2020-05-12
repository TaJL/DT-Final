using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Billboard : MonoBehaviour {
  void Update () {
    transform.forward = transform.position - Camera.main.transform.position;
  }
}
