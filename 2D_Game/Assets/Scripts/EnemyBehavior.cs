using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    Rigidbody2D myPlayer;
    [SerializeField] float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myPlayer = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //   if (isFacingRight())
        if (playerIsRightOfMe())
        {
           myRigidBody.velocity = new Vector2(moveSpeed, 0f);
           // GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
       else
        {
            myRigidBody.velocity = new Vector2(-moveSpeed, 0f);
           // GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    bool isFacingRight()
    {
        return transform.localScale.x > 0;
    }

    bool playerIsRightOfMe()
    {
        if (myRigidBody.velocity.x < myPlayer.velocity.x)
        {
            return true;
        } 
        else
        {
            return false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
//        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody.velocity.x)), 1f);
    }
}
