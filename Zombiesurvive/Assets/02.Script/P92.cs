using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P92 : MonoBehaviour {
    public int ShotDamage = 5;
    public float ShotDelay = 0.5f;
    public float Range = 10f;
    Z_Faster Z_FasterHealth;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, this.transform.forward * Range, Color.red);
        if (Input.GetKey("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Range))
            {
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    Debug.Log(hit.collider.name);
                }
            }

        }
	}
}
