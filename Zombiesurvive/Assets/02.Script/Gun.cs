using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public int ShotDamage = 0;
    public float ShotDelay = 0;
    public float Range = 0;

    float timer;
    Ray shootRay = new Ray();
    RaycastHit shootHit;
    int shootableMask;
    LineRenderer gunLine;
    Light gunLight;
    public Light faceLight;
    //ParticleSystem gunParticles;
    float EffectTime = 0.2f;

    protected virtual void Awake()
    {
        shootableMask = LayerMask.GetMask("Shootable");

       // gunParticles = GetComponent<ParticleSystem>();
        gunLine = GetComponent<LineRenderer>();
        gunLight = GetComponent<Light>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer >= ShotDelay && Time.timeScale != 0)
        {
            Shoot();
        }
        if(timer >= ShotDelay * EffectTime)
        {
            DisableEffects();
        }
    }
    protected virtual void DisableEffects()
    {
        gunLine.enabled = false;
        gunLight.enabled = false;
      //  faceLight.enabled = false;
    }
    protected virtual void Shoot()
    {
        timer = 0;
        gunLight.enabled = true;
        //faceLight.enabled = true;

       // gunParticles.Play();
        //gunParticles.Stop();

        gunLine.enabled = true;
        gunLine.SetPosition(0, transform.parent.position);

        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        if (Physics.Raycast(shootRay, out shootHit, Range, shootableMask))
        {
            // Try and find an EnemyHealth script on the gameobject hit.
            Enemy enemyHealth = shootHit.collider.GetComponent<Enemy>();

            // If the EnemyHealth component exist...
            if (enemyHealth != null)
            {
                // ... the enemy should take damage.
                enemyHealth.TakeDamage(ShotDamage);
            }

            // Set the second position of the line renderer to the point the raycast hit.
            gunLine.SetPosition(1, shootHit.point);
        }
        else
        {
            gunLine.SetPosition(1, transform.position + (transform.forward * Range));
        }

    }
}
