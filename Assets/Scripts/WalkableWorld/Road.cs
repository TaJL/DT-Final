using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Road : MonoBehaviour {
  public Builder visual;
  public Transform obstacles;
  public Platform connected;

  void OnEnable () {
    Hide();
  }

  public void Hide () {
    visual.Hide();
    obstacles.gameObject.SetActive(true);
    if (connected) connected.visual.Hide();
  }

  public void Show () {
    visual.Show();
    obstacles.gameObject.SetActive(false);
    if (connected) connected.visual.Show();
  }
}
