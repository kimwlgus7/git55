using UnityEngine;

public class PlayerExample : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystick;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate () 
	{
        //float moveh = joystick.Horizontal;
        //float movev = joystick.Vertical;

        Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
        transform.Translate(new Vector3(joystick.Horizontal, 0, joystick.Vertical).normalized * moveSpeed * Time.deltaTime, Space.World);
        //Vector3 movement = new Vector3(moveh, 0f, movev).normalized;
        //rb.AddForce(movement * moveSpeed);

    }
}