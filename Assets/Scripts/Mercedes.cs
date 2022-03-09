using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercedes : Car , IGerman
{
    public bool ýsSweam { get; set; }

    public override void MakeSell1()
    {
        TotalPrice = Price;

        if (IsNew)
        {
            TotalPrice += 5000m;
        }
        if (ýsSweam)
        {
            TotalPrice += 6000m;
        }
    }

    public override void MakeSell2()
    {
        throw new System.NotImplementedException();
    }
    public bool IsGerman { get; set; }

    public void GermanMakeSell()
    {
        if (IsGerman)
        {
            TotalPrice -= 3000m;
        }
    }
}