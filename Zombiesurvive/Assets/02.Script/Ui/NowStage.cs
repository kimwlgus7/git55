using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowStage : MonoBehaviour {
    Text t;
    Stage stage;
	// Use this for initialization
	void Start () {
        t = GameObject.Find("Stage").GetComponent<Text>();
        stage = GameObject.Find("GameManager").GetComponent<Stage>();
	}
	
	// Update is called once per frame
	void Update () {
        t.text = "STAGE" + stage.currentstage;
	}
}
