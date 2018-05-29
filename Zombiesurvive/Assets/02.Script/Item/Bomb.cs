using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
    public int BompHp = 50;
    public int Damage;
    Enemy Enemyhp;
    public GameObject effect;
    
	// Use this for initialization
	void Start () {
        //Enemyhp = GameObject.FindObjectOfType<Enemy>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            other.GetComponent<Enemy>().TakeDamageBomb(Damage);
            Debug.Log("touch");
        }
    }
    public void TakeDamage(int damage)
    {
        BompHp -= damage;
        if (BompHp <= 0)
        {
            gameObject.GetComponent<SphereCollider>().enabled = true;
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject, 0.3f);
            
        }
    }
}
