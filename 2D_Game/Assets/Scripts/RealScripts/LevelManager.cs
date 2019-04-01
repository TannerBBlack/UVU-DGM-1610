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

    // Use this for initialization
    void Start (){
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    public void RespawnPlayer(){
        StartCoroutine ("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo(){
        //Generate death particles
        Instantiate (deathParticles, pcRigid.transform.position, pcRigid.transform.rotation);
        //Hide PC
        player.SetActive(false);
        player.GetComponent<Renderer> ().enabled = false;
        //Gravity reset
        gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //point penalty
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        //debug message
        Debug.Log ("PC Respawn");
        //respawn delay
        yield return new WaitForSeconds (respawnDelay);
        //gravity restore
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //match PCs transform position
        pcRigid.transform.position = currentCheckPoint.transform.position;
        //show pc
        player.SetActive(true);
        pcRigid.GetComponent<Renderer> ().enabled = true;
        //spawn pc
        Instantiate (respawnParticles, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
    }
}
