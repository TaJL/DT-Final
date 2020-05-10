using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Mixer : NonPersistantSingleton<Mixer>
{
    [SerializeField] private AudioMixer audio_mixer;
    [SerializeField]
    private AudioSource SFXs_source;
    [SerializeField]
    private AudioSource Music_source;

    [SerializeField] private Tween tweener_data;
    void Start()
    {
        
    }
    
    public void TweenCutOff(float end, float in_time, float out_time)
    {
        StopAllCoroutines();
        float start = 22000;
        IEnumerator Routine()
        {
            yield return StartCoroutine(TweenCutOffRoutine(start,end,in_time));
            yield return StartCoroutine(TweenCutOffRoutine(end,start,out_time));
        }
        StartCoroutine(Routine());
    }
    IEnumerator TweenCutOffRoutine(float start, float end,float time) {
        float counter = 0;
        do
        {
            counter = Mathf.Clamp01(counter + Time.deltaTime/time);
            var value = Mathf.LerpUnclamped(start, end, (counter));
            audio_mixer.SetFloat("Cutoff", value);
            yield return null;
        } while (counter < 1f);
    }
}