using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selecter : MonoBehaviour {
    public Image selecter;
    public GameObject select0;
    public GameObject select1;
    public GameObject select2;
    public GameObject select3;
    public GameObject select4;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {		
	}
    public void Select()
    {
        selecter.gameObject.SetActive(true);
        RandomSelect();

    }
    public void RandomSelect()
    {
        int r = Random.Range(0, 5);

        switch(r)
        {
            case 0:
                select0.gameObject.SetActive(true);
                selecter.gameObject.SetActive(false);
                Debug.Log("0");
                break;
            case 1:
                select1.gameObject.SetActive(true);
                selecter.gameObject.SetActive(false);
                Debug.Log("1");
                break;
            case 2:
                select2.gameObject.SetActive(true);
                selecter.gameObject.SetActive(false);
                Debug.Log("2");
                break;
            case 3:
                select3.gameObject.SetActive(true);
                selecter.gameObject.SetActive(false);
                Debug.Log("3");
                break;
            case 4:
                select4.gameObject.SetActive(true);
                selecter.gameObject.SetActive(false);
                Debug.Log("4");
                break;
        }
    }
}
