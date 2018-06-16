using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi.SavedGame;
using System;
using GooglePlayGames.BasicApi;

public class L : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayGamesPlatform.Activate();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShowBoard()
    {
        Social.ShowLeaderboardUI();
        Debug.Log("!!");
    }
    public void ShowAchievement()
    {
        Social.ShowAchievementsUI();
    }
}
