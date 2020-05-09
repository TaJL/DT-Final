using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Cooldown {
  public event System.Action onOver;
  public bool IsOver { get => current <= 0;}

  public Vector2 available;
  public float current;
  public float occurrenceProbability = 1;
  public bool resetsOnOver = true;
  public bool randomStart = true;

  bool _initialized;
  bool _fired = false;

  public void Update () {
    if (!_initialized && randomStart) _Initialize();

    current -= Time.deltaTime;

    if (!_fired && current <= 0) {
      _fired = true;
      if (onOver != null && Random.Range(0,1f) <= occurrenceProbability) onOver();
      if (resetsOnOver) {
        Reset();
      }
    }
  }

  public void Reset () {
    current = Random.Range(available.x, available.y);
    _fired = false;
  }

  void _Initialize () {
    _initialized = true;
    current = Random.Range(0, Mathf.Max(available.x, available.y));
  }
}
