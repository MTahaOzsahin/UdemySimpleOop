using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Cabin : Places // sealed oldu�u zaman miras�n� kimseye veremez anlam�na gelir.
{
    public override void Show()
    {
        if (IsAvailable)
        {
            Debug.Log("M�sait");
        }
    }
}
