using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpSlider : MonoBehaviour {
    Text t;
    public PlayerHealth h;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        t.text = h.PlayerExp + " / " + h.NeedExp;
	}
}
