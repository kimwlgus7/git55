using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
    Text t;
	// Use this for initialization
	void Start () {
        t = GameObject.Find("Time").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        float timer = GameObject.Find("GameManager").GetComponent<Stage>().timer;
        t.text = timer.ToString("N2");
	}
}
