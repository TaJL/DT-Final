using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class AvailableDecissions {
  public string North;
  public string West;
  public string South;
  public string East;

  public string Get (string decision) {
    return Get((Decision) System.Enum.Parse(typeof(Decision), decision));
  }

  public string Get (Decision decision) {
    switch (decision) {
      case Decision.North: return North;
      case Decision.West: return West;
      case Decision.South: return South;
      case Decision.East: return East;
    }

    return "";
  }
}
