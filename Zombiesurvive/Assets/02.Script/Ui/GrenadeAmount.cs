using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrenadeAmount : MonoBehaviour {
    Text t;
    PlayerExample grenade;
	// Use this for initialization
	void Start () {
        t = GameObject.Find("grenadeText").GetComponent<Text>();
        grenade = GameObject.Find("Player").GetComponent<PlayerExample>();
	}
	
	// Update is called once per frame
	void Update () {
        t.text = grenade.grenadeamount.ToString();
	}
}
