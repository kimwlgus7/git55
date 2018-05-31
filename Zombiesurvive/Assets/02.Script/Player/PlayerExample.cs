using UnityEngine;

public class PlayerExample : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystick;
    Rigidbody rb;
    Animator anim;
    public GameObject grenade;
    Rigidbody gb;
    public GameObject Bombposition;
    public int grenadeamount;
    public Joystick joystick2;

    private void Start()
    {
        grenadeamount = 10;
        anim = GameObject.Find("Character").GetComponent<Animator>();
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
        if (joystick.Horizontal == 0 && joystick.Vertical == 0 && (joystick2.Horizontal != 0 || joystick2.Vertical != 0))
        {
            anim.SetBool("IsAttack2", true);
        }
        else
            anim.SetBool("IsAttack2", false);

    }
    public void Grenade()
    {
        if(grenadeamount > 0)
        {
            Instantiate(grenade, Bombposition.transform.position, Bombposition.transform.rotation);
            grenadeamount -= 1;
        }
        
    }
}