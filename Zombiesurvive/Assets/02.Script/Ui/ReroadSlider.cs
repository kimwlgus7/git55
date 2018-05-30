using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReroadSlider : MonoBehaviour {
    float timer;
    Slider ss;
    Gun gun;
    
	// Use this for initialization
	void Start () {
        ss = GameObject.Find("ReroadSlider").GetComponent<Slider>();
        gun = GameObject.FindObjectOfType<Gun>();
	}
	
	// Update is called once per frame
	void Update () {
        //timer += Time.deltaTime;
        //ss.maxValue = gun.ReroadTime;
        //ss.minValue = gun.ReroadTimer;
    }
    public void ReroadTime()
    {
        timer = 0f;
    }
}
