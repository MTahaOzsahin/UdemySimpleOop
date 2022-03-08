using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Villa : Places // sealed oldu�u zaman miras�n� kimseye veremez anlam�na gelir.
{
    public Villa(string adress, string name, int area, int roomNumber, bool �sRent, bool �sSale, decimal price, bool �sAvailable)
    {
        Adress = adress;
        Name = name;
        Area = area;
        RoomNumber = roomNumber;
        IsRent = �sRent;
        IsSale = �sSale;
        Price = price;
        IsAvailable = �sAvailable;
    }

    public override void Show()
    {
        if (IsAvailable)
        {
            Debug.Log("M�sait");
        }
    }
}