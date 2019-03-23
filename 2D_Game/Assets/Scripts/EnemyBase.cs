using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : PhysicsObject
{
   /* [SerializeField] enum EnemyType { Bug, Zombie };
    [SerializeField] EnemyType enemyType;
    public AudioSource audioSource;
    public float maxSpeed = 7;
    private float launch = 1;
    [SerializeField] float launchPower = 10;
    public float direction = 1;
    [SerializeField] public float changeDirectionEase = 1;
    private float directionSmooth = 1;
    [SerializeField] private int health = 3;
    [SerializeField] private GameObject deathParticles;
    public float jumpTakeOffSpeed = 7;
    public bool jump = false;
    private float playerDifference;
    public string groundType = "grass";
    public AudioClip stepSound;
    public AudioClip jumpSound;
    public AudioClip grassSound;
    public AudioClip stoneSound;
    public bool recovering;
    public float recoveryCounter;
    public float recoveryTime = 2;
    private bool followPlayer;
    public float followRange;
    [SerializeField] private LayerMask layerMask;

    [SerializeField] private GameObject graphic;
    [SerializeField] private Animator animator;
    [SerializeField] private bool jumping;
    private RaycastHit2D ground;
    [SerializeField] private Vector2 rayCastOffset;
    private RaycastHit2D rightWall;
    private RaycastHit2D leftWall;
    private RaycastHit2D rightLedge;
    private RaycastHit2D leftLedge;

    void Start()
    {

    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, followRange);
    }

    protected override void ComputeVelocity()
    {

        Vector2 move = Vector2.zero;
        playerDifference = NewPlayer.Instance.gameObject.transform.position.x - transform.position.x;
        directionSmooth += (direction - directionSmooth) * Time.deltaTime * changeDirectionEase;
        if (!NewPlayer.Instance.frozen && !recovering)
        {
            move.x = 1 * directionSmooth;

            //Flip the graphic depending on the speed
            if (move.x > 0.01f)
            {
                if (graphic.transform.localScale.x == -1)
                {
                    graphic.transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
                }
            }
            else if (move.x < -0.01f)
            {
                if (graphic.transform.localScale.x == 1)
                {
                    graphic.transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
                }
            }

            //Check floor type
            ground = Physics2D.Raycast(transform.position, -Vector2.up);
            Debug.DrawRay(transform.position, -Vector2.up, Color.green);



            //Check if player is within range to follow

            if (enemyType == EnemyType.Zombie)
            {
                if ((Mathf.Abs(playerDifference) < followRange))
                {
                    followPlayer = true;
                }
                else
                {
                    followPlayer = false;
                }
            }

            if (followPlayer)
            {
                if (playerDifference < 0)
                {
                    direction = -1;
                }
                else
                {
                    direction = 1;
                }
            }
            else
            {
                //Allow enemy to instantly change direction when not following player
                directionSmooth = direction;
            }



            //Check for walls
            rightWall = Physics2D.Raycast(new Vector2(transform.position.x + rayCastOffset.x, transform.position.y + rayCastOffset.y), Vector2.right, 1f, layerMask);
            Debug.DrawRay(new Vector2(transform.position.x, transform.position.y + rayCastOffset.y), Vector2.right, Color.yellow);

            if (rightWall.collider != null)
            {
                if (!followPlayer)
                {
                    direction = -1;
                }
                else
                {
                    Jump();
                }

            }

            leftWall = Physics2D.Raycast(new Vector2(transform.position.x - rayCastOffset.x, transform.position.y + rayCastOffset.y), Vector2.left, 1f, layerMask);
            Debug.DrawRay(new Vector2(transform.position.x, transform.position.y + rayCastOffset.y), Vector2.left, Color.blue);

            if (leftWall.collider != null)
            {
                if (!followPlayer)
                {
                    direction = 1;
                }
                else
                {
                    Jump();
                }
            }


            //Check for ledges
            if (!followPlayer)
            {
                rightLedge = Physics2D.Raycast(new Vector2(transform.position.x + rayCastOffset.x, transform.position.y), Vector2.down, .5f);
                Debug.DrawRay(new Vector2(transform.position.x + rayCastOffset.x, transform.position.y), Vector2.down, Color.blue);
                if (rightLedge.collider == null)
                {
                    direction = -1;
                }

                leftLedge = Physics2D.Raycast(new Vector2(transform.position.x - rayCastOffset.x, transform.position.y), Vector2.down, .5f);
                Debug.DrawRay(new Vector2(transform.position.x - rayCastOffset.x, transform.position.y), Vector2.down, Color.blue);

                if (leftLedge.collider == null)
                {
                    direction = 1;
                }
            }
        }

        animator.SetBool("grounded", grounded);
        animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);
        targetVelocity = move * maxSpeed;
    }

    public void Jump()
    {
        if (grounded)
        {
            velocity.y = jumpTakeOffSpeed;
        }
    }*/
}
