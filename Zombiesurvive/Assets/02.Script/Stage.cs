using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject[] allenemy;
    public int currentstage;
    public float timer = 60;
    public GameObject TimerUi;

	// Use this for initialization
	void Start () {
        StartCoroutine(stage1());
        currentstage = 1;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        //allenemy = GameObject.FindGameObjectsWithTag("Enemy");
        //if (timer <= 0)
        //{
        //    TimerUi.SetActive(false);
        //}
        //if(currentstage ==1 && allenemy.Length == 0)
        //{
        //    timer = 5f;
        //}
	}
    IEnumerator stage1()
    {
        timer = 60;
        TimerUi.SetActive(true);
        Stage1.SetActive(true);
        yield return new WaitForSeconds(10f);
        Stage1.SetActive(false);
        yield return new WaitForSeconds(50f);
        TimerUi.SetActive(false);
        allenemy = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in allenemy)
        {
            Destroy(enemy);
        }
        yield return new WaitForSeconds(5f);
        //stage2();
        timer = 60;
        TimerUi.SetActive(true);
        currentstage = 2;
        yield return new WaitForSeconds(5f);
        Stage2.SetActive(true);
        yield return new WaitForSeconds(10f);
        Stage2.SetActive(false);
        yield return new WaitForSeconds(45f);
        TimerUi.SetActive(false);
        allenemy = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in allenemy)
        {
            Destroy(enemy);
        }
        yield return new WaitForSeconds(5f);
    }
    //IEnumerator stage2()
    //{
    //    timer = 0;
    //    TimerUi.SetActive(true);
    //    currentstage = 2;
    //    yield return new WaitForSeconds(5f);
    //    Stage2.SetActive(true);
    //    yield return new WaitForSeconds(10f);
    //    Stage2.SetActive(false);
    //    yield return new WaitForSeconds(40f);
    //    TimerUi.SetActive(false);
    //    allenemy = GameObject.FindGameObjectsWithTag("Enemy");
    //    foreach (GameObject enemy in allenemy)
    //    {
    //        Destroy(enemy);
    //    }
    //    yield return new WaitForSeconds(5f);
    //    stage2();
    //}
}
