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

    public GameObject ak47item;
    public GameObject p92item;
    public GameObject healingitem;
    public GameObject grenadelauncher;
    public GameObject coin;
    bool navset = true;

    //public GameObject ak47box;
    //public GameObject p92box;
    //public GameObject coin;
    //public Transform itemposition;


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
            if(navset == true)
            {
                nav.isStopped = true;
            }
            

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
            if (navset == true)
            {
                nav.isStopped = false;
            }
        }
    }


    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        if(navset == true)
        {
            nav.SetDestination(player.position);
        }
        if (timer >= DelayTime && AttackDelay == true && attackable == false)
        {
            timer = 0;
            attackable = true;
        }
        else if(attackable == false)
        {
            //nav.SetDestination(player.position);
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
        navset = false;
        Destroy(this.gameObject, 2);
        //Destroy(GetComponent<CapsuleCollider>());
        Destroy(GetComponent<NavMeshAgent>());
        //nav.isStopped = true;
        playerHealth.PlayerExp = playerHealth.PlayerExp + EnemyExp;
        gameObject.layer = 0;
        GetItem();

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
    public virtual void TakeDamageGrenade(int damage)
    {
        EnemyHealth -= damage;
        if (EnemyHealth <= 0)
        {
            Death();
        }
    }
    public virtual void GetItem()
    {
        int r = Random.Range(0, 10);
        switch (r)
        {
            case 0:
                {
                    Instantiate(ak47item, this.gameObject.transform.position, this.gameObject.transform.rotation);
                    break;
                }
            case 1:
                {
                    Instantiate(p92item, this.gameObject.transform.position, this.gameObject.transform.rotation);
                    break;
                }
            case 2:
                {
                    Instantiate(healingitem, this.gameObject.transform.position, healingitem.transform.localRotation);
                    break;
                }

            case 3:
                {
                    //Instantiate(grenadelauncher, this.gameObject.transform.position, this.gameObject.transform.rotation);
                    break;
                }
            case 4:
                {
                    Instantiate(coin, this.gameObject.transform.position, this.gameObject.transform.rotation);
                    break;
                }
            case 5:
                {
                    break;
                }
            case 6:
                {
                    break;
                }
            case 7:
                {
                    break;
                }
            case 8:
                {
                    break;
                }
            case 9:
                {
                    break;
                }
            case 10:
                {
                    break;
                }
        }
    }
        
    //public virtual void GetItem1()
    //{
    //    int r = Random.Range(0, 1);
    //    switch (r)
    //    {
    //        case 0:
    //            Instantiate(ak47box, this.transform);
    //            Debug.Log("0");
    //            break;
    //        case 1:
    //            Instantiate(p92box, this.transform);
    //            Debug.Log("0");
    //            break;

    //    }
    }
