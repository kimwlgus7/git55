using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {

    Rigidbody playerRigid;
    public Joystick joystick;
    Vector3 lookDirection;
	// Use this for initialization
	void Start () {
		playerRigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
        //Quaternion newRotation = Quaternion.LookRotation(moveVector);
        //playerRigid.MoveRotation(newRotation)
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            Turning();
        }
    }

    void Turning()
    {
        float x = joystick.Horizontal;
        float y = joystick.Vertical;
        lookDirection = (x * Vector3.right + y * Vector3.forward).normalized;
        this.transform.rotation = Quaternion.LookRotation(lookDirection);
    }
}
