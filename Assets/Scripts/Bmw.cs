using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Bmw : Car //mühürlendiði zamanda baþka birine miras veremez anlamýna gelir.
{
    // bu bir constructer yani yapýcý bir methodtur. Kýsayol yazýmý ctor tap tap.
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
    //ctorlar monobehiver da çalýþmaz
    public Bmw(string model, string brand, float speed, byte doorNumber, bool ýsNew, bool ýsFly, decimal price)
    {
        Model = model;
        Brand = brand;
        DoorNumber = doorNumber;
        IsNew = ýsNew;
        IsFly = ýsFly;
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
