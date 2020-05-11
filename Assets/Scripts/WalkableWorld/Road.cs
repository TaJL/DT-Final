using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class Road : MonoBehaviour {
  public Builder visual;
  public Transform obstacles;
  public Platform connected;
    [Header("Sound")]
    public AudioManager audioManager;
    [Header("construct")]
    public float constructVolume;

    void OnEnable () {
    Hide();
  }

  void Reset () {
    visual = GetComponentInChildren<Builder>();
    obstacles = GetComponentInChildren<NavMeshObstacle>().transform.parent;
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
        audioManager.PlaySound(0, constructVolume);
  }
}
