using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
    public int BompHp = 50;
    public int Damage;
    Enemy Enemyhp;
	// Use this for initialization
	void Start () {
        Enemyhp = GameObject.FindObjectOfType<Enemy>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            Enemyhp.TakeDamageBomb(Damage);
            Debug.Log("touch");
        }
    }
    public void TakeDamage(int damage)
    {
        BompHp -= damage;
        if (BompHp <= 0)
        {
            gameObject.GetComponent<SphereCollider>().enabled = true;
            Destroy(gameObject, 0.5f);
        }
    }
}
