using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlaneFollower : MonoBehaviour
{
    [SerializeField] private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
            transform.position = new Vector3(target.position.x,transform.position.y,target.position.z);
    }
}
