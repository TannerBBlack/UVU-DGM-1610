using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {

    public ParticleSystem myCoolParticle; 

	// Use this for initialization
	void Start () {
         
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ParticleToggle()
    {
        if (myCoolParticle.isPlaying)
        {
            myCoolParticle.Stop();
        }
        else
        {
            myCoolParticle.Play();
        }
    }
}
