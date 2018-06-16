using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi.SavedGame;
using System;
using GooglePlayGames.BasicApi;

public class PlayerHealth : MonoBehaviour {
    public int StartingHealth = 100;
    public int CurrentHealth = 10;
    public int Score = 0;
    public Slider Hpbar;
    public int PlayerLevel = 1;
    public float PlayerExp = 0;
    public float NeedExp = 200;
    public Selecter select;
    public Slider Expbar;
    public int getmoney = 0;
    public GameObject redflash;
    Animator anim;
    Enemy enemyattack;
    
    
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        anim = GameObject.Find("Character").GetComponent<Animator>();
        CurrentHealth = StartingHealth;
        Hpbar.maxValue = StartingHealth;
        Expbar.maxValue = NeedExp;
        
        
    }
	
	// Update is called once per frame
	void Update () {
        Hpbar.value = CurrentHealth;
        Expbar.maxValue = NeedExp;
        Expbar.value = PlayerExp;
        redflash.SetActive(false);

        if (PlayerExp >= NeedExp)
        {
            LevelUp();
        }

        //Debug.Log(Score);
        //Debug.Log(CurrentHealth);
        if(CurrentHealth <= 0)
        {
            PlayerDeath();
        }
        if (Score <= 1000)
            Social.ReportProgress(GPGSIds2.achievement_bronzescore, 100f, null);
        else if (Score <= 3000)
            Social.ReportProgress(GPGSIds2.achievement_silverscore, 100f, null);
        else if (Score <= 5000)
            Social.ReportProgress(GPGSIds2.achievement_goldscore, 100f, null);
        else if (Score <= 8000)
            Social.ReportProgress(GPGSIds2.achievement_platinumscore, 100f, null);
        else if (Score <= 15000)
            Social.ReportProgress(GPGSIds2.achievement_diamondscore, 100f, null);


    }
    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        redflash.SetActive(true);
        


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
    public void PlayerDeath()
    {
        Destroy(GetComponent<PlayerExample>());
        anim.SetBool("IsDead", true);
        gameObject.tag = "Untagged";
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true);
        Social.ReportScore(Score, "CgkIl_yphtUIEAIQAA", success =>
        {
            Debug.Log("report_score");
            Debug.Log(success);
        });
        
    }
}
