using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BuggyLayout : MonoBehaviour {
  IEnumerator Start () {
    GetComponent<LayoutGroup>().enabled = false;
    yield return null;
    GetComponent<LayoutGroup>().enabled = true;
    yield return null;
    GetComponent<LayoutGroup>().enabled = false;
    yield return null;
    GetComponent<LayoutGroup>().enabled = true;
  }
}
