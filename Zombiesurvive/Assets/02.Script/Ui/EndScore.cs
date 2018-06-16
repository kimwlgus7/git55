using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {
    Text t;
    int score;
    // Use this for initialization
    private void Awake()
    {
        score = GameObject.Find("Plan").GetComponent<Lastscore>().playerscore;
        t = GetComponent<Text>();
    }
    void Start () {
        t.text = "score : " + score;

    }
	
	// Update is called once per frame
	void Update () {
        
        
    }
}
