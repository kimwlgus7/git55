using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Button RoketLauncherUI;
    public Button Ak47UI;
    public Button P92UI;
    public GameObject Ak47;
    public GameObject P92;
    public GameObject RoketLauncher;
    public GameObject Akrender;
    public GameObject P92render;
    public GameObject Roketrender;
    GameObject currentItem;
    protected GameObject FiledItem;
    public GameObject BulletAmount;
    AK47 ak;
    P92 p92;
    // Use this for initialization
    void Start()
    {
        currentItem = P92;
        ak = Ak47.GetComponent<AK47>();
        p92 = P92.GetComponent<P92>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ak47Box")
        {
            if (currentItem == Ak47)
            {
                currentItem.GetComponent<AK47>().ReserveBullet += currentItem.GetComponent<AK47>().Bullet * 2;
                Destroy(other.gameObject);
            }
            else
            {
                FiledItem = other.gameObject;
                Ak47UI.gameObject.SetActive(true);
            }

        }
        if (other.gameObject.tag == "P92Box")
        {
            if (currentItem == P92)
            {
                currentItem.GetComponent<P92>().ReserveBullet += currentItem.GetComponent<P92>().Bullet * 2;
                Destroy(other.gameObject);
            }
            else
            {
                FiledItem = other.gameObject;
                P92UI.gameObject.SetActive(true);
            }

        }
        if (other.gameObject.tag == "RoketBox")
        {
            if (currentItem == RoketLauncher)
            {
                currentItem.GetComponent<Roket>().ReserveBullet += currentItem.GetComponent<Roket>().Bullet * 2;
                Destroy(other.gameObject);
            }
            else
            {
                FiledItem = other.gameObject;
                RoketLauncherUI.gameObject.SetActive(true);


            }



        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Ak47Box")
        {
            Ak47UI.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "P92Box")
        {
            P92UI.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "RoketBox")
        {
            RoketLauncherUI.gameObject.SetActive(false);
        }
    }
    public void ChangeAk47()
    {
        if (FiledItem == null)
            return;

       if(currentItem == null || currentItem.name != "AK47")
        {
            currentItem = Ak47;
            Ak47UI.gameObject.SetActive(false);
            Ak47.SetActive(true);
            P92.SetActive(false);
            Akrender.SetActive(true);
            P92render.SetActive(false);
            p92.CurrentBullet = p92.Bullet;
            p92.ReserveBullet = p92.Bullet * 2;
            //Roketrender.SetActive(false);
        }
        else if(currentItem != null && currentItem.name == "AK47")
        {
            Ak47UI.gameObject.SetActive(false);
            currentItem.GetComponent<AK47>().ReserveBullet += currentItem.GetComponent<AK47>().Bullet*2;
            //Debug.Log("RR : " + currentItem.GetComponent<AK47>().ReserveBullet);
        }

        Destroy(FiledItem);
    }
    public void ChangeP92()
    {
        if (FiledItem == null)
            return;

        if (currentItem == null || currentItem.name != "P92")
        {
            currentItem = P92;
            P92UI.gameObject.SetActive(false);
            P92.SetActive(true);
            Ak47.SetActive(false);
            RoketLauncher.SetActive(false);
            Akrender.SetActive(false);
            P92render.SetActive(true);
            ak.CurrentBullet = ak.Bullet;
            ak.ReserveBullet = ak.Bullet * 2;
            
            //Roketrender.SetActive(false);
        }
        else if (currentItem != null && currentItem.name == "P92")
        {
            P92UI.gameObject.SetActive(false);
            currentItem.GetComponent<P92>().ReserveBullet += currentItem.GetComponent<P92>().Bullet * 2;
            //Debug.Log("RR : " + currentItem.GetComponent<P92>().ReserveBullet);
        }

        Destroy(FiledItem);
    }
    public void ChangeRoket()
    {
        if (FiledItem == null)
            return;

        if (currentItem == null || currentItem.name != "RoketLauncher")
        {
            currentItem = RoketLauncher;
            RoketLauncherUI.gameObject.SetActive(false);
            RoketLauncher.SetActive(true);
            Ak47.SetActive(false);
            P92.SetActive(false);
            Roketrender.SetActive(true);
            Akrender.SetActive(false);
            P92render.SetActive(false);
        }
        else if (currentItem != null && currentItem.name == "RoketLauncher")
        {
            RoketLauncherUI.gameObject.SetActive(false);
            currentItem.GetComponent<Roket>().ReserveBullet += currentItem.GetComponent<Roket>().Bullet * 2;
            //Debug.Log("RR : " + currentItem.GetComponent<AK47>().ReserveBullet);
        }

        Destroy(FiledItem);
    }
}

