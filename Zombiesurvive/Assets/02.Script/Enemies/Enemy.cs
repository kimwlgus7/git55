using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    Animator anim;
    PlayerHealth playerHealth;
    Transform player;
    NavMeshAgent nav;
    public float timer;
    public float EnemyHealth = 100;
    protected bool AttackDelay;
    public float DelayTime = 2f;
    public int AttackDamage = 5;
    public int damage = 0;
    public int playerscore = 0;
    public float EnemyExp;

    bool attackable = false;

    // Use this for initialization
    protected virtual void Awake()
    {
        anim = GetComponent<Animator>();
    }
    protected virtual void Start()
    {
        player = GameObject.Find("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        playerHealth = GameObject.FindObjectOfType<PlayerHealth>();
        anim.SetBool("IsRun", true);
    }
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            AttackDelay = true;
           
                
            anim.SetBool("IsRun", false);
            nav.isStopped = true;
            
            //Attack();
        }
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            anim.SetBool("IsAttack", false);
            anim.SetBool("IsRun", true);
            AttackDelay = false;
            nav.isStopped = false;
        }
    }

    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        

        if (timer >= DelayTime && AttackDelay == true && attackable == false)
        {
            //nav.isStopped = true;
            timer = 0;
            attackable = true;
        }
        else if(attackable == false)
        {
            nav.SetDestination(player.position);
            timer += Time.deltaTime;
        }
            

        

        anim.SetBool("IsAttack", attackable);
    }
    protected virtual void Attack()
    {

        if(AttackDelay)
        {
            playerHealth.TakeDamage(AttackDamage);
            timer = 0;
        }
    }

    public void AttackEnd()
    {
        attackable = false;
    }

    public virtual void TakeDamage(int damage)
    {
        if (EnemyHealth <= 0)
            return;

        EnemyHealth -= damage;

        if (EnemyHealth <= 0)
        {

            //playerHealth.TakeScore(playerscore);
            Death();
        }
        Debug.Log("daamge");
    }
    public virtual void Death()
    {
        anim.SetBool("IsDead", true);
        Destroy(this.gameObject, 2);
        //Destroy(GetComponent<CapsuleCollider>());
        Destroy(GetComponent<Rigidbody>());
        nav.Stop();
        playerHealth.PlayerExp = playerHealth.PlayerExp + EnemyExp;
        Debug.Log("Exp");
        gameObject.layer = 0;

    }
    public virtual void TakeDamageBomb(int damage)
    {
        EnemyHealth -= damage;
        Debug.Log("bomb!");
        if(EnemyHealth <= 0)
        {
            Death();
        }
    }

}