using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi.SavedGame;
using System;
using GooglePlayGames.BasicApi;
public class ScoreBoard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayGamesPlatform.Activate();
        ConectarGoogle();
	}

    private void ConectarGoogle()
    {
        Social.localUser.Authenticate((bool success) =>
         {
             if (true == success)
             {
                 Debug.Log("Login");
             }
             else
             {
                 Debug.Log("Login Fail !!");
             }
         });
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

    // Update is called once per frame
    void Update () {
		
	}
}
