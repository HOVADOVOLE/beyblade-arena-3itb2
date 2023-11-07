using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuff : Buff
{
    //TODO odkaz na hr��e
    float dmg = 5; // Za hr��e
    protected override void ApplyBuff()
    {
        dmg *= buffPower;
        Timer();
    }
    protected override void Timer()
    {
        base.Timer();
        dmg /= buffPower;
    }
    private void OnCollisionEnter(Collision collision)
    {
        ApplyBuff();
        Destroy(this);
    }

}
