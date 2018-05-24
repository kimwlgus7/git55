using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public int ShotDamage = 0;
    public float ShotDelay = 0;
    public float Range = 0;
    public float ReroadTime = 0;//장전시간
    public int Bullet;//기본장탄
    public int CurrentBullet;//현재탄수
    float ReroadTimer;
    public int ReserveBullet = 10;//장탄수
    public PlayerRotation playerrotation;


    float timer;
    Ray shootRay = new Ray();
    RaycastHit shootHit;
    [SerializeField]
    LayerMask shootableMask;
    int shootableMask2;
    LineRenderer gunLine;
    Light gunLight;
    public Light faceLight;
    //ParticleSystem gunParticles;
    float EffectTime = 0.2f;

    protected virtual void Awake()
    {
        //shootableMask = LayerMask.GetMask("Shootable");
        shootableMask2 = LayerMask.GetMask("Bomber");

       // gunParticles = GetComponent<ParticleSystem>();
        gunLine = GetComponent<LineRenderer>();
        gunLight = GetComponent<Light>();
    }
    // Use this for initialization
    protected virtual void Start () {
        CurrentBullet = Bullet;
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        //Debug.Log("CurrentBullet : " + CurrentBullet);

        timer += Time.deltaTime;

        if (CurrentBullet <= 0)
        {
            if(ReserveBullet > 0)
            {
                if (ReroadTimer >= ReroadTime)
                {
                    ReroadTimer = 0;
                    CurrentBullet = Bullet;
                    if(ReserveBullet < Bullet)
                    {
                        CurrentBullet = ReserveBullet;
                        ReserveBullet = 0;
                    }
                    else
                    {
                        ReserveBullet -= CurrentBullet;
                    }
                    
                }
                else
                {
                    ReroadTimer += Time.deltaTime;
                }
            }
        }

        if ((playerrotation.joystick.Horizontal !=0 || playerrotation.joystick.Vertical != 0) && timer >= ShotDelay && Time.timeScale != 0)
        {
           
            if(CurrentBullet > 0)
            {
                Shoot();
            }

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
        CurrentBullet -= 1;

        if (Physics.Raycast(shootRay, out shootHit, Range, shootableMask))
        {

            // Try and find an EnemyHealth script on the gameobject hit.
            Enemy enemyHealth = shootHit.collider.GetComponent<Enemy>();
            Bomb bombhp = shootHit.collider.GetComponent<Bomb>();


            // If the EnemyHealth component exist...
            if (enemyHealth != null)
            {
                // ... the enemy should take damage.
                enemyHealth.TakeDamage(ShotDamage);
            }

            if(bombhp != null)
            {
                bombhp.TakeDamage(ShotDamage);
            }

            // Set the second position of the line renderer to the point the raycast hit.
            gunLine.SetPosition(1, shootHit.point);

        }
        else
        {
            gunLine.SetPosition(1, transform.position + (transform.forward * Range));
        }
        //if (Physics.Raycast(shootRay, out shootHit, Range, shootableMask2))
        //{

        //    // Try and find an EnemyHealth script on the gameobject hit.
        //    Bomb bombhp = shootHit.collider.GetComponent<Bomb>();
            

        //    // If the EnemyHealth component exist...
        //    if (bombhp != null)
        //    {
        //        // ... the enemy should take damage.
        //        bombhp.TakeDamage(ShotDamage);
        //    }

        //    // Set the second position of the line renderer to the point the raycast hit.
        //    gunLine.SetPosition(1, shootHit.point);

        //}
        //else
        //{
        //    gunLine.SetPosition(1, transform.position + (transform.forward * Range));
        //}

    }
}

