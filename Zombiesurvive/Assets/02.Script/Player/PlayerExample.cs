using UnityEngine;

public class PlayerExample : MonoBehaviour {

    public float moveSpeed;
    public float rotateSpeed;
    public Joystick joystick;

	void Update () 
	{
        Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical);//nomalized
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
	}
}