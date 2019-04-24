using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBetweenAttack;
    public float startTimeBetweenAtack;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public int damage;

    public Animator player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Animator>();
        player.SetBool("Attacking", false);
    }

    // Update is called once per frame
    void Update()
    {
        if(startTimeBetweenAtack <= 0)
        {
            //then you can attack
            if (Input.GetKeyDown(KeyCode.Space))
            {
                timeBetweenAttack = startTimeBetweenAtack;

                player.SetBool("Attacking", true);

                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyFollow>().TakeDamage(damage);
                }
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                player.SetBool("Attacking", false);
            }
            
        }
        else
        {
            timeBetweenAttack -= Time.deltaTime;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
