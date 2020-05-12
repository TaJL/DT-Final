using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class Road : MonoBehaviour {
  public event System.Action onDecisionTaken;

  public AudioClip sfx;
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

  public void Hide (bool pretty = false) {
    visual.Hide(pretty);
    obstacles.gameObject.SetActive(true);
    if (connected) connected.visual.Hide(pretty);
  }

  public void Show () {
    visual.Show();
    obstacles.gameObject.SetActive(false);

    if (onDecisionTaken != null) onDecisionTaken();

    if (connected) connected.visual.Show();
    //     audioManager.PlaySound(0, constructVolume);
    Sfx.Instance.speaker.PlayOneShot(sfx);

  }
}
