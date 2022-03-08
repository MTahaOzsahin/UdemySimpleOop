using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car //abstract demek soyut anlam�na gelir ve tek g�revi sadece miras vermektir new alamaz ba�ka bir �ey yapamaz �a��r�lamaz
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public bool IsNew { get; set; }
    public float TopSpeed { get; set; }
    public byte DoorNumber { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice { get; protected set; } //b�ylelikle bu bilgi sadece bu class �zerinde de�i�tirilebilir olacak. Ba�ka s�n�flar ise sadece bilgiyi okuyabilecek.
   // privattte sadece olu�tu�u class da eri�ilebilir iken protected olu�tu�u class ve miras gitti�i classda eri�ilebilir.
    public virtual void MakeSell1() //virtual oldu�u zaman istersek method oldu�u gibi kullan�l�r istersek de ezip �st�nde oynamalar yapabiliriz.
    {
        TotalPrice = Price;
        if (IsNew)
        {
            TotalPrice += 5000m;
        }
       
    }

    public abstract void MakeSell2();
    /*abstract oldu�u zaman miras gitti�i t�m classlarda �a��r�lmak implent edilmek zorundad�r ve �st�nde oynama da yapmak zorunday�z.
     * Yani diyelim ki 1. method bir ka� s�n�fta oldu�u gibi kullanmak istiyoruz ba�ka bir ka� classda de�i�tirmek istiyoruz �st�ne ekleme istiyoruz.
     * o zaman virtual ile yazar�z. 
     * Ama diyelim ki 2. method her miras gitti�i classda �a��r�p �zerinde oynama yaparak kullanaca��z o zaman
     * abstract ile yazar�z ki gitti�i her classda �a��r�l�p �st�nde
     * de�i�tirilmek zorunda kals�n
     */
}
