using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {
    public GameObject stage1_1;
    public GameObject stage1_2;
    public GameObject stage1_3;


    Instance mobdelay;

	// Use this for initialization
	void Start () {
        StartCoroutine(stage1());
	}

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator stage1()
    {
        stage1_1.SetActive(true);
        //stage1_2.SetActive(true);
        //stage1_3.SetActive(true);
        yield return new WaitForSeconds(10f);
        stage1_1.SetActive(false);
        //stage1_2.SetActive(false);
        //stage1_3.SetActive(false);
        yield return new WaitForSeconds(60f);
        
    }
        
}
