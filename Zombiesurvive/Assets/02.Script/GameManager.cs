using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Orientation();
	}
    void Orientation()
    {
        DeviceOrientation currentOrientation = Input.deviceOrientation;

        switch (currentOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                Screen.orientation = ScreenOrientation.LandscapeLeft;
                break;
            case DeviceOrientation.LandscapeRight:
                Screen.orientation = ScreenOrientation.LandscapeRight;
                break;
        }
    }
    public void MainScene()
    {
        SceneManager.LoadSceneAsync("0.Main");
    }
}
