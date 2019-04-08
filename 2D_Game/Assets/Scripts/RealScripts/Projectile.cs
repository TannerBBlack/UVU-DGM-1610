using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    public float timeOut;

    public GameObject enemyDeath;

    public GameObject projectileParticle;
    
    public int pointsForKill;

    // Start is called before the first frame update
    void Start()
    {
     player = GameObject.Find("Player");

     enemyDeath = Resources.Load("Prefabs/Death_PS") as GameObject;

     projectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;

     if(player.transform.localScale.x < 0)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
