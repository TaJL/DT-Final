using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(int clipNumber, float volume, float variation = 0, float pitch = 1)
    {
        float volumeVariation = 0;
        audioSource.pitch = pitch;
        if (variation != 0)
        {
            audioSource.pitch += Random.Range(-variation, variation);
            volumeVariation = Random.Range(-variation, variation) / 2;
        }

        audioSource.PlayOneShot(clips[clipNumber], volume + volumeVariation);
    }
}
