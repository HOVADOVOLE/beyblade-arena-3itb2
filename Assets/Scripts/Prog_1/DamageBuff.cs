using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuff : Buff
{
    //TODO odkaz na hr��e
<<<<<<< HEAD
    float dmg = 5; // Za hr��e
=======
    float dmg = 5; // Z hr��e
>>>>>>> 7a401534e12fa1492681e80fdcafc7fe3df74ab0
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
