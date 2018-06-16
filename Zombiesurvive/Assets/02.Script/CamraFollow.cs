using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraFollow : MonoBehaviour {
    public Transform player;
    public float smoothing = 5f;
    Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 targetCampos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCampos, smoothing * Time.deltaTime);
	}
}
