using UnityEngine;

public class PlayerExample : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystick;
    Rigidbody rb;
    Animator anim;
    public GameObject grenade;
    Rigidbody gb;

    private void Start()
    {
        anim = GameObject.Find("Character").GetComponent<Animator>();
        gb = grenade.GetComponent<Rigidbody>();
    }

    void FixedUpdate () 
	{
        //float moveh = joystick.Horizontal;
        //float movev = joystick.Vertical;

        Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
        transform.Translate(new Vector3(joystick.Horizontal, 0, joystick.Vertical).normalized * moveSpeed * Time.deltaTime, Space.World);
        if(joystick.Horizontal == 0 || joystick.Vertical == 0)
        {
            anim.SetBool("IsRun", false);
        }
        else
        {
            anim.SetBool("IsRun", true);
        }
        //Vector3 movement = new Vector3(moveh, 0f, movev).normalized;
        //rb.AddForce(movement * moveSpeed);

    }
    public void Grenade()
    {
        Instantiate(grenade, this.gameObject.transform.position, this.gameObject.transform.rotation);
        //gb.AddForce(Vector3.up);

    }
}