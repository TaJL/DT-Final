using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bottom : NonPersistantSingleton<Bottom> {
  public static float PosY { get => Instance.transform.position.y; }
}
