using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_Tanker : Enemy {

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

    }

    protected override void Attack()
    {
        base.Attack();
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage/5);

    }
    public override void Death()
    {
        base.Death();
    }
}
