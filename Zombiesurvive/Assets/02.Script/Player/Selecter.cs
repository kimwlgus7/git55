﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selecter : MonoBehaviour {
    public Image selecter;
    Gun gun;
    PlayerHealth player;
    PlayerExample player2;

    

    // Use this for initialization
    void Start () {
        gun = GameObject.FindObjectOfType<Gun>();
        player = GameObject.FindObjectOfType<PlayerHealth>();
        player2 = GameObject.FindObjectOfType<PlayerExample>();
    }
	
	// Update is called once per frame
	void Update () {		
	}
    public void Select()
    {
        
        selecter.gameObject.SetActive(true);
        RandomSelect();
        Time.timeScale = 0;

    }
    public void RandomSelect()
    {
        int r = Random.Range(0, 5);
        int l = Random.Range(0, 5);
        int i = Random.Range(0, 5);
        Debug.Log(r);

        switch(r)
        {
            case 0:
                GameObject.Find("Selecter").transform.GetChild(0).gameObject.SetActive(true);

                //selecter.gameObject.SetActive(false);
                Debug.Log("0");
                break;
            case 1:
                GameObject.Find("Selecter").transform.GetChild(1).gameObject.SetActive(true);
                //button = GameObject.Find("Selecter").transform.Find("select1").gameObject;
                //button.gameObject.SetActive(true);
                Debug.Log("1");
                break;
            case 2:
                GameObject.Find("Selecter").transform.GetChild(2).gameObject.SetActive(true);
                Debug.Log("2");
                break;
            case 3:
                GameObject.Find("Selecter").transform.GetChild(3).gameObject.SetActive(true);
                Debug.Log("3");
                break;
            case 4:
                GameObject.Find("Selecter").transform.GetChild(4).gameObject.SetActive(true);
                Debug.Log("4");
                break;
        }
        switch (l)
        {
            case 0:
                GameObject.Find("Selecter").transform.GetChild(5).gameObject.SetActive(true);

                //selecter.gameObject.SetActive(false);
                Debug.Log("0");
                break;
            case 1:
                GameObject.Find("Selecter").transform.GetChild(6).gameObject.SetActive(true);
                //button = GameObject.Find("Selecter").transform.Find("select1").gameObject;
                //button.gameObject.SetActive(true);
                Debug.Log("1");
                break;
            case 2:
                GameObject.Find("Selecter").transform.GetChild(7).gameObject.SetActive(true);
                Debug.Log("2");
                break;
            case 3:
                GameObject.Find("Selecter").transform.GetChild(8).gameObject.SetActive(true);
                Debug.Log("3");
                break;
            case 4:
                GameObject.Find("Selecter").transform.GetChild(9).gameObject.SetActive(true);
                Debug.Log("4");
                break;
        }
        switch (i)
        {
            case 0:
                GameObject.Find("Selecter").transform.GetChild(10).gameObject.SetActive(true);

                //selecter.gameObject.SetActive(false);
                Debug.Log("0");
                break;
            case 1:
                GameObject.Find("Selecter").transform.GetChild(11).gameObject.SetActive(true);
                //button = GameObject.Find("Selecter").transform.Find("select1").gameObject;
                //button.gameObject.SetActive(true);
                Debug.Log("1");
                break;
            case 2:
                GameObject.Find("Selecter").transform.GetChild(12).gameObject.SetActive(true);
                Debug.Log("2");
                break;
            case 3:
                GameObject.Find("Selecter").transform.GetChild(13).gameObject.SetActive(true);
                Debug.Log("3");
                break;
            case 4:
                GameObject.Find("Selecter").transform.GetChild(14).gameObject.SetActive(true);
                Debug.Log("4");
                break;
        }
    }
    public void Bigmagazine()
    {
        gun.Bullet += 10;
        Time.timeScale = 1;
        selecter.gameObject.SetActive(false);
    }
    public void Quickdraw()
    {
        gun.ReroadTime -= 0.5f;
        Time.timeScale = 1;
        selecter.gameObject.SetActive(false);
    }
    public void Healingfull()
    {
        player.CurrentHealth = player.StartingHealth;
        Time.timeScale = 1;
        selecter.gameObject.SetActive(false);
    }
    public void SpeedUp()
    {
        player2.moveSpeed += 0.2f;
        Time.timeScale = 1;
        selecter.gameObject.SetActive(false);
    }
}
