using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class TestAgent : MonoBehaviour {
  void OnEnable () {
    GetComponent<NavMeshAgent>().SetDestination(transform.forward * 10 + transform.position);
  }
}
