﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_Faster : Enemy {
    // Use this for initialization
    protected override void Awake()
    {
        base.Awake();
    }
    protected override void Start () {
        base.Start();
    }

    // Update is called once per frame
    protected override void FixedUpdate () {
        base.FixedUpdate();

    }

    protected override void Attack()
    {
        base.Attack();
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
    public override void Death()
    {
        base.Death();
    }
    public override void TakeDamageBomb(int damage)
    {
        base.TakeDamageBomb(damage);
    }

    public override void TakeDamageGrenade(int damage)
    {
        base.TakeDamageGrenade(damage);
    }

    public override void GetItem()
    {
        base.GetItem();

    }
}
