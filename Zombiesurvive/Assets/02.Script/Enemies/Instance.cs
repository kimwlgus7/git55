using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour {
    public GameObject gameObject;
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
            Instantiate(gameObject, gameObject.transform.position, gameObject.transform.rotation);
            timer = 0;
        }
	}
}
