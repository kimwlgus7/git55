using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour {
    public GameObject zombie;
    public float ZombieDelay = 2;
    float timer;
    public Transform position;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= ZombieDelay)
        {
            Instantiate(zombie, this.gameObject.transform.position, this.gameObject.transform.rotation);
            timer = 0;
        }
	}
}
