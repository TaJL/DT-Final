using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleCountHandler : MonoBehaviour
{
    public static FinaleCountHandler Instance;
    public bool moralRota = false;
    public bool balance = false;
    public bool maldad = false;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
}
