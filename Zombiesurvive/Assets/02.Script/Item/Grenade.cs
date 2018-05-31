using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {
    public int grenadedamage;
    Rigidbody rb;
    float timer;
    float grenadetime=10;
    public GameObject effect;
    Vector3 dir;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void Start () {
        rb.AddForce(transform.forward*1000f);
        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gameObject.GetComponent<SphereCollider>().enabled = true;
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject, 0.3f);
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
