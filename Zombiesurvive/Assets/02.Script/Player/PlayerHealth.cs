using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public int StartingHealth = 100;
    public int CurrentHealth = 10;
    public int Score = 0;
    public Slider Hpbar;
    public int PlayerLevel = 1;
    public float PlayerExp = 0;
    public float NeedExp = 200;
    public Selecter select;
    
    
	// Use this for initialization
	void Start () {
        CurrentHealth = StartingHealth;
        Hpbar.maxValue = StartingHealth;
        
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(PlayerExp);
        Hpbar.value = CurrentHealth;
        
        if(PlayerExp >= NeedExp)
        {
            LevelUp();
        }
    }
    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
    }
    public void TakeScore(int score)
    {
        Score += score;
        
    }

    public void Change(float value)
    {
        if(value == 0)
        {
            Debug.Log("Death");
        }
    }
    public void LevelUp()
    {
        PlayerLevel += 1;
        PlayerExp = 0;
        NeedExp *= 2;
        select.Select();
    }
}
