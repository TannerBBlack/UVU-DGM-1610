using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public int health;
    private float speed;
    private float dazedTime;
    public float startDazedTime;
    private Transform target;
    Rigidbody2D myRigidBody;
    private Vector3 scale;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        myRigidBody = GetComponent<Rigidbody2D>();
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target. position) < 10)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if(dazedTime <= 0){
            speed = 7;
        } 
        else {
            speed = 0;
            dazedTime -= Time.deltaTime;
        }

        FlipSprite();
        
    }

    public void TakeDamage(int damage)
    {
        dazedTime = startDazedTime;
        health -= damage;
        Debug.Log("damage taken");
    }

    private void FlipSprite()
    {

        if (speed > 0)
        {
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        }

        else if(speed < 0)
        {
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        }
    }
}
