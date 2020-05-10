using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class SteroidAgent : MonoBehaviour {
  public event System.Action onArrival;
  public NavMeshAgent agent;
  public bool bussy = false;

  void Reset () {
    agent = GetComponent<NavMeshAgent>();
  }

  void OnDisable () {
    StopAllCoroutines();
  }

  public void GoTo (Vector3 pos) {
    bussy = true;
    if (pos == transform.position) {
      bussy = false;
      if (onArrival != null) onArrival();
    } else {
      agent.SetDestination(pos);
      StartCoroutine(_MonitorPath());
    }
  }

  IEnumerator _MonitorPath () {
    // while (!agent.hasPath || agent.pathPending) {
    while (agent.pathPending) {
      // print("it doesn't have a path " + Time.time);
      yield return null;
    }

    while (agent.remainingDistance > agent.stoppingDistance * 1.1f &&
           !(!agent.hasPath && agent.velocity.sqrMagnitude == 0)) {
      // print("the path isn't over " + Time.time);
      yield return null;
    }

    // print("reach!");
    agent.velocity = Vector3.zero;
    agent.isStopped = true;
    agent.ResetPath();
    if (onArrival != null) onArrival();
    bussy = false;
  }
}
