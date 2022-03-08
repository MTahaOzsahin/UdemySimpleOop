using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Cabin : Places // sealed olduðu zaman mirasýný kimseye veremez anlamýna gelir.
{
    public override void Show()
    {
        if (IsAvailable)
        {
            Debug.Log("Müsait");
        }
    }
}
