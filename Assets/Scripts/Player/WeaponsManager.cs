using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponsManager : MonoBehaviour {
  public Shield shield;

  public void CollectShield () {
    shield.gameObject.SetActive(true);
  }
}
