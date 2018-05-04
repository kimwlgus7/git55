using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    PlayerHealth playerHealth;
    Transform player;
    UnityEngine.AI.NavMeshAgent nav;
    public float timer;
    public float EnemyHealth = 100;
    protected bool AttackDelay;
    public float DelayTime = 2f;
    public int AttackDamage = 5;
    public int damage = 0;
    // Use this for initialization
    protected virtual void Start()
    {
        player = GameObject.Find("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        playerHealth = GameObject.FindObjectOfType<PlayerHealth>();
    }
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            AttackDelay = true;
            Attack();
        }

    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            AttackDelay = false;
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        nav.SetDestination(player.position);
        timer += Time.deltaTime;
    }
    protected virtual void Attack()
    {
        if (timer >= DelayTime && AttackDelay == true)
        {
            playerHealth.TakeDamage(AttackDamage);
            timer = 0;
        }
    }
    public virtual void TakeDamage(int damage)
    {
        EnemyHealth -= damage;
    }
    public virtual void Death()
    {
    }

}