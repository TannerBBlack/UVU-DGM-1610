using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Player movement variables
	public float moveSpeed; 
	public float jumpHeight;
	private bool doubleJump;
    private Vector3 scale;

	//Player grounded variables
	private bool grounded;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
    public float health;

	//Non-Slide Player 
	private float moveVelocity;

    //Animator
    public Animator player;


	// Use this for initialization
	void Start () {
        // Default to true on grounded
        player = GetComponent<Animator>();
        player.SetBool("Walking", false);
        

        scale = transform.localScale;
		
	}
	
	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {
		// Moves player left and right
		if(Input.GetKey(KeyCode.D)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = moveSpeed;
            player.SetBool("Walking", true);
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            player.SetBool("Walking", false);
        }


        if (Input.GetKey(KeyCode.A)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
            player.SetBool("Walking", true);
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            player.SetBool("Walking", false);
        }
		
		//Moving left and right code
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);		

		// Make player jump
		if(Input.GetKeyDown(KeyCode.W) && grounded){
			Jump();
		}

		//Double Jump
		if(grounded){
			doubleJump = false;
		}

		if(Input.GetKeyDown (KeyCode.W) && !doubleJump && !grounded){
			Jump();
			doubleJump = true;
		}

		//Non-Slide Player
		moveVelocity = 0f;

        




	}

	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}

}