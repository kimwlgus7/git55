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
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        nav.SetDestination(player.position);

        if (timer >= DelayTime && AttackDelay == true && attackable == false)
        {
            timer = 0;
            attackable = true;
        }
        else if(attackable == false)
            timer += Time.deltaTime;

        

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
        Destroy(GetComponent<BoxCollider>());
        nav.Stop();
        playerHealth.PlayerExp = playerHealth.PlayerExp + EnemyExp;

    }

}