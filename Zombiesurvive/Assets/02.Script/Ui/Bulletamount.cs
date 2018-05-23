using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bulletamount : MonoBehaviour {
    Text t;
    public AK47 Ak47;
    public P92 P92;

    // Use this for initialization
    void Start () {
        t = GetComponent<Text>();
        
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if(Ak47.gameObject.activeSelf == true)
        {
            t.text = Ak47.CurrentBullet + " / " + Ak47.ReserveBullet;
        }
        if (P92.gameObject.activeSelf == true)
        {
            t.text = P92.CurrentBullet + " / " + P92.ReserveBullet;
        }


        
	}
}
