using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : Buff
{
    //TODO odkaz na hr·Ëe
    float speed = 5; // Z hr·Ëe
    protected override void ApplyBuff()
    {
        speed *= buffPower;
    }
    protected override void Timer()
    {
        base.Timer();
        speed /= buffPower;
    }
    private void OnCollisionEnter(Collision collision)
    {
        ApplyBuff();
        Destroy(this);
    }
}
