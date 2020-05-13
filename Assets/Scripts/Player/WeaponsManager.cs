using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponsManager : MonoBehaviour {
  public Shield shield;
  public Gun gun;

  public void CollectShield () {
    shield.gameObject.SetActive(true);
  }

  public void CollectGun () {
    gun.gameObject.SetActive(true);
  }
}
