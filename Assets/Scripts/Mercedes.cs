using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercedes : Car
{
    public bool �sSweam { get; set; }

    public override void MakeSell1()
    {
        TotalPrice = Price;

        if (IsNew)
        {
            TotalPrice += 5000m;
        }
        if (�sSweam)
        {
            TotalPrice += 6000m;
        }
    }

    public override void MakeSell2()
    {
        throw new System.NotImplementedException();
    }
}