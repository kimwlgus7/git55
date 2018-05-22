﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P92 : Gun {

    // Use this for initialization
    protected override void Awake()
    {
        base.Awake();
    }

    void Start () {
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();
        Debug.DrawRay(transform.position, this.transform.forward * Range, Color.red);
        
	}
    protected override void DisableEffects()
    {
        base.DisableEffects();
    }
}