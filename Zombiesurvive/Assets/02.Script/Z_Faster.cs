using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_Faster : MonoBehaviour {
    public float Z_FasterHealth = 5;
    public int AttackDamage = 5;
    //[SerializeField]
    PlayerHealth playerHealth;
    bool AttackDelay;
    public float DelayTime = 2f;
    float timer;
    // Use this for initialization
    void Start () {
        playerHealth = GameObject.FindObjectOfType<PlayerHealth>();

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

    }
    //void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        AttackDelay = true;
    //        Attack();
    //    }

    //}
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

    void Attack()
    {
        if (timer >= DelayTime && AttackDelay == true)
        {
            playerHealth.TakeDamage(AttackDamage);
            timer = 0;
        }
    }
}
