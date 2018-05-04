using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int StartingHealth = 100;
    public int CurrentHealth = 10;
	// Use this for initialization
	void Start () {
        CurrentHealth = StartingHealth;
    }
	
	// Update is called once per frame
	void Update () {
	}
    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
    }
}
