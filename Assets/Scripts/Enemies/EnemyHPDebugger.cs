using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class EnemyHPDebugger : MonoBehaviour {
  public TextMeshPro text;
  public AttackableEnemy attackable;
  public Color damaged;
  public Color normal;
  public Renderer r;

  void Update () {
    text.text = attackable.hp + "";
    transform.forward = transform.position - Camera.main.transform.position;

    if (!attackable.cooldown.IsOver) {
      r.material.color = damaged;
    } else {
      r.material.color = normal;
    }
  }
}
