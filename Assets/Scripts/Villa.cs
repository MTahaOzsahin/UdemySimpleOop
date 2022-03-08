using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Villa : Places // sealed olduðu zaman mirasýný kimseye veremez anlamýna gelir.
{
    public Villa(string adress, string name, int area, int roomNumber, bool ýsRent, bool ýsSale, decimal price, bool ýsAvailable)
    {
        Adress = adress;
        Name = name;
        Area = area;
        RoomNumber = roomNumber;
        IsRent = ýsRent;
        IsSale = ýsSale;
        Price = price;
        IsAvailable = ýsAvailable;
    }

    public override void Show()
    {
        if (IsAvailable)
        {
            Debug.Log("Müsait");
        }
    }
}