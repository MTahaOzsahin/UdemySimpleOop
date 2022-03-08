using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car //abstract demek soyut anlamýna gelir ve tek görevi sadece miras vermektir new alamaz baþka bir þey yapamaz çaðýrýlamaz
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public bool IsNew { get; set; }
    public float TopSpeed { get; set; }
    public byte DoorNumber { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice { get; protected set; } //böylelikle bu bilgi sadece bu class üzerinde deðiþtirilebilir olacak. Baþka sýnýflar ise sadece bilgiyi okuyabilecek.
   // privattte sadece oluþtuðu class da eriþilebilir iken protected oluþtuðu class ve miras gittiði classda eriþilebilir.
    public virtual void MakeSell1() //virtual olduðu zaman istersek method olduðu gibi kullanýlýr istersek de ezip üstünde oynamalar yapabiliriz.
    {
        TotalPrice = Price;
        if (IsNew)
        {
            TotalPrice += 5000m;
        }
       
    }

    public abstract void MakeSell2();
    /*abstract olduðu zaman miras gittiði tüm classlarda çaðýrýlmak implent edilmek zorundadýr ve üstünde oynama da yapmak zorundayýz.
     * Yani diyelim ki 1. method bir kaç sýnýfta olduðu gibi kullanmak istiyoruz baþka bir kaç classda deðiþtirmek istiyoruz üstüne ekleme istiyoruz.
     * o zaman virtual ile yazarýz. 
     * Ama diyelim ki 2. method her miras gittiði classda çaðýrýp üzerinde oynama yaparak kullanacaðýz o zaman
     * abstract ile yazarýz ki gittiði her classda çaðýrýlýp üstünde
     * deðiþtirilmek zorunda kalsýn
     */
}
