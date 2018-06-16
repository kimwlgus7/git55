using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("1.fight");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
