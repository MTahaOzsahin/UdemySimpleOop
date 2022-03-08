using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Places //class abstract oldu�u i�in miras gitti�i hi� bir yerde new"lenemez.
{
    public string Name { get; set; }
    public string Adress { get; set; }
    public int Area { get; set; }
    public int RoomNumber { get; set; }
    public bool IsRent { get; set; }
    public bool IsSale { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }

    public abstract void Show(); //Method abstract oldu�u i�in miras gitti�i her yerde implant edilmek zorundad�r.
}
