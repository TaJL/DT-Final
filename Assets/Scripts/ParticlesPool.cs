using UnityEngine;
using  System.Collections.Generic;
using System;
using UnityEditor;

[Serializable]
public class ParticlesPool
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int start_size = 3;
    
    private List<ParticleSystem> particles; 

    public void Initialize()
    {
        particles = new List<ParticleSystem>();
        for (int i = 0; i < start_size; i++)
        {
            particles.Add((GameManager.Instantiate(prefab) as GameObject).GetComponent<ParticleSystem>());
            particles[particles.Count-1].gameObject.SetActive(false);
        }
    }
    public void PlayParticleAt(Vector3 position)
    {
        var particle = GetAvailableParticle();
        particle?.gameObject.SetActive(true);
        particle?.transform.SetPositionAndRotation(position,Quaternion.identity);
        particle?.Play();
    }
    private ParticleSystem GetAvailableParticle()
    {
        for (int i = 0; i < particles.Count; i++)
        {
            if (!particles[i].isEmitting)
                return particles[i];
        }
        return null;
    }

    public void ReleaseResources()
    {
        while (particles.Count > 0)
        {
            if(particles[0])
                GameManager.Destroy(particles[0].gameObject);
            particles.RemoveAt(0);
        }
    }
}
