using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFinishedParticle : MonoBehaviour
{
    //Helmi Kinnunen 
    //Luotu 20.2.2018

    private ParticleSystem thisParticleSystem;

    // Use this for initialization
    void Start()
    {
        thisParticleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(thisParticleSystem.isPlaying)
        {
            return;
        }

        Destroy(gameObject);
    }
}
