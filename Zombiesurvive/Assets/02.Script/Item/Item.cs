using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Button Ak47UI;
    public Button P92UI;
    public GameObject Ak47;
    public GameObject P92;
    GameObject currentItem;
    GameObject FiledItem;

    //int ReserveBullet;
    //int CurrentBullet;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ak47Box")
        {
            FiledItem = other.gameObject;
            //currentItem = Ak47;
            Ak47UI.gameObject.SetActive(true);
        }
        if (other.gameObject.tag == "P92Box")
        {
            FiledItem = other.gameObject;
            //currentItem = P92;
            P92UI.gameObject.SetActive(true);

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
        }
        else if(currentItem != null && currentItem.name == "AK47")
        {
            Ak47UI.gameObject.SetActive(false);
            currentItem.GetComponent<AK47>().ReserveBullet += currentItem.GetComponent<AK47>().Bullet*2;
            Debug.Log("RR : " + currentItem.GetComponent<AK47>().ReserveBullet);
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
        }
        else if (currentItem != null && currentItem.name == "P92")
        {
            P92UI.gameObject.SetActive(false);
            currentItem.GetComponent<P92>().ReserveBullet += currentItem.GetComponent<P92>().Bullet * 2;
            Debug.Log("RR : " + currentItem.GetComponent<P92>().ReserveBullet);
        }

        Destroy(FiledItem);
    }
}

