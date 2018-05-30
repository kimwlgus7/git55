using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {
    public int grenadedamage;
    Rigidbody rb;
    float timer;
    float grenadetime=10;
    public GameObject effect;
    private void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }
    void Start () {
        rb.AddForce(new Vector3(0, 50, 0));
        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gameObject.GetComponent<SphereCollider>().enabled = true;
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= grenadetime)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            other.GetComponent<Enemy>().TakeDamageGrenade(grenadedamage);
        }
    }
}
