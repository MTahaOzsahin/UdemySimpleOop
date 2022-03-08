using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Bmw : Car //m�h�rlendi�i zamanda ba�ka birine miras veremez anlam�na gelir.
{
    // bu bir constructer yani yap�c� bir methodtur. K�sayol yaz�m� ctor tap tap.
   public Bmw()
    {

    }

    public Bmw(string model)
    {
        Model = model;
    }
    public Bmw(string model, string brand)
    {
        Model = model;
        Brand = brand;
    }
    //ctorlar monobehiver da �al��maz
    public Bmw(string model, string brand, float speed, byte doorNumber, bool �sNew, bool �sFly, decimal price)
    {
        Model = model;
        Brand = brand;
        DoorNumber = doorNumber;
        IsNew = �sNew;
        IsFly = �sFly;
        Price = price;

        MakeSell1();


    }
    public bool IsFly { get; set; }

    public override void MakeSell1()
    {
        TotalPrice = Price;
        if (IsNew)
        {
            TotalPrice += 4000m;
        }
        if (IsNew)
        {
            TotalPrice += 6000m;
        }
    }

    public override void MakeSell2()
    {
        throw new System.NotImplementedException();
    }
}
