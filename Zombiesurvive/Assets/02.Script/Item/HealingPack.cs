using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPack : MonoBehaviour {
    PlayerHealth player;
    public int healingamount;
	// Use this for initialization
	void Start () {
        player = GameObject.FindObjectOfType<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(0, 0, 1);
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (player.CurrentHealth < player.StartingHealth)
            {
                if (player.CurrentHealth + healingamount > player.StartingHealth)
                {
                    player.CurrentHealth = player.StartingHealth;
                    Destroy(gameObject);
                }
                else
                {
                    player.CurrentHealth += healingamount;
                    Destroy(gameObject);
                }
            }
            else
                Destroy(gameObject);
        }
    }
}
