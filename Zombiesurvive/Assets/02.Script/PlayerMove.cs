using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float MoveSpeed = 1f;
    float camRayLangth = 100f;
    Rigidbody playerRigid;
    Vector3 movement;
    int floorMask;

    void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");
        playerRigid = GetComponent<Rigidbody>();

    }
    void Start () {
		
	}
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Move(h, v);
        Turning();
    }
	
	// Update is called once per frame
	void Update () {
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        //h = h * MoveSpeed * Time.deltaTime;
        //v = v * MoveSpeed * Time.deltaTime;
        //transform.Translate(Vector3.right * h);
        //transform.Translate(Vector3.forward * v);
	}
    void Move(float h, float v)
    {
        movement.Set(h, 0, v);

        movement = movement.normalized * MoveSpeed * Time.fixedDeltaTime;

        playerRigid.MovePosition(transform.position + movement);
    }
    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit floorHit;

        if (Physics.Raycast(camRay, out floorHit, camRayLangth, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;

            playerToMouse.y = 0f;
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playerRigid.MoveRotation(newRotation);
        }
    }
}
