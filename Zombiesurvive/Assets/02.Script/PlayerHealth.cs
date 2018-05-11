using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int StartingHealth = 100;
    public int CurrentHealth = 10;
    public int Score = 0;
	// Use this for initialization
	void Start () {
        CurrentHealth = StartingHealth;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Score);
    }
    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
    }
    public void TakeScore(int score)
    {
        Score += score;
        
    }
}
