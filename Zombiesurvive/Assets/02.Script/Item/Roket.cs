using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roket : Gun {

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        Debug.DrawRay(transform.position, this.transform.forward * Range, Color.red);

    }
    protected override void DisableEffects()
    {
        base.DisableEffects();
    }
    public override void ReroadTimers()
    {
        base.ReroadTimers();
    }
    protected override void Reroad()
    {
        base.Reroad();
    }
}
