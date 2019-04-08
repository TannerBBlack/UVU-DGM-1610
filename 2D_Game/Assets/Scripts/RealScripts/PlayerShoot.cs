using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        //:pad Projectile from Resources/Prefabs Folder
        projectile = Resources.Load("Bullets") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.RightControl)){
           Instantiate(projectile,firePoint.position, firePoint.rotaion);
       }

    }
}
