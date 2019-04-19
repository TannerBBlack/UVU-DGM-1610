using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            HealthBarScript.health -= 10f;
        }
    }
}
