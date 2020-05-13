using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ender : MonoBehaviour
{
    public int scene_id = 0;

    private void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.tag);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene_id);
        }
    }
}