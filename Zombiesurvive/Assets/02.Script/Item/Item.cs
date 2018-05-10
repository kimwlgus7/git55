using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Button Ak47Box;
    public Button P92Box;
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
            
            Destroy(other.gameObject);
        }
    }
}
