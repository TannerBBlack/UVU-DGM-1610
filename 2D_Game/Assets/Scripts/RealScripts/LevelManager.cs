using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject currentCheckPoint;
    public Rigidbody2D pcRigid;

    private GameObject player;

    // Particles
    public GameObject deathParticles;
    public GameObject respawnParticles;

    //Respawn Delay
    public float respawnDelay;
    
    //Point Penalty on Death
    public int pointPenaltyOnDeath;

    //Store Gravity Value
    private float gravityStore;

    void Start (){
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }
}
