using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainProcesss : MonoBehaviour
{
    [Header("First Inputs")]
    public InputField firstNameFirstInput;
    public InputField lastNameFirstInput;
    public InputField ageFirstInput;

    [Header("Second Inputs")]
    public InputField firstNameSecondInput;
    public InputField lastNameSecondInput;
    public InputField ageSecondInput;

    [Header("Result Text")]
    public Text resultFirstNameText;
    public Text resultAgeText;

    private void Start()
    {
        //ctor simple
        Bmw bmw1 = new Bmw("M","BMW",280f,2,true,true,10000m);
        

        string resultBmw = "BMW total price is " + bmw1.TotalPrice;

        bmw1.MakeSell1();

        Mercedes mercedes = new Mercedes();
        mercedes.Brand = "Mercedes";
        mercedes.Model = "AMG";
        mercedes.TopSpeed = 320f;
        mercedes.DoorNumber = 4;
        mercedes.IsNew = true;
        mercedes.ýsSweam = true;
        mercedes.Price = 12000m;

        string resultMercedes = "Mercedess total price is " + mercedes.TotalPrice;

       // EstateAgent();

    }

    public void ButtonClickFirst()
    {
        People people1 = new People();
        people1.FirstName = firstNameFirstInput.text; //set
        people1.LastName = lastNameFirstInput.text;
        people1.Age = int.Parse(ageFirstInput.text);

        resultFirstNameText.text = people1.FirstName; //get
        resultAgeText.text = people1.Age.ToString();
    }

    public void ButtonClickSecond()
    {
        People people1 = new People();
        people1.FirstName = firstNameSecondInput.text;
        people1.LastName = lastNameSecondInput.text;
        people1.Age = int.Parse(ageSecondInput.text);
    }

    private void InheritanceSample ()
    {
        Worker worker = new Worker();
        worker.FirstName = "Taha";
        worker.LastName = "aaa";
        worker.Age = 23;
        worker.Salary = 1500m;

        // ctrl + space kýsayol
        Costumer costumer = new Costumer
        {
            FirstName = "Nur",
            LastName = "aaaa",
            Age = 20,
            BirthDate = DateTime.Now,
            CreditCardInfo1 = "123123124"
        };
    }

    private void EstateAgent () // Self simple
    {
        Apartman apartman = new Apartman("Beþiktaþ", "ZekiBey", 90, 3, false, true, 90000m, true);

        string resultApartman = "Bu ev " + apartman.Adress + "adresinde " + apartman.Name + "isminde " + apartman.Area + "m2 büyüklüðünde " + apartman.RoomNumber
             + "oda sayýlýdýr. " + "Satýlýk olup fiyatý: " + apartman.Price + "Uygundur.";

        Cabin cabin = new Cabin();
        cabin.Adress = "Levent";
        cabin.Name = "Adnan";
        cabin.Area = 45;
        cabin.RoomNumber = 1;
        cabin.IsRent = true;
        cabin.IsSale = false;
        cabin.IsAvailable = true;

        string resultCabin = "Bu ev " + cabin.Adress + "adresinde " + cabin.Name + "isminde " + cabin.Area + "m2 büyüklüðünde " + cabin.RoomNumber
             + "oda sayýlýdýr. " + "Kiralýk olup fiyatý: " + apartman.Price + "Uygundur.";

        Villa villa = new Villa("Üsküdar", "Tatyos", 150, 6, false, true, 800000m, true);

        string resultVilla = "Bu ev " + villa.Adress + "adresinde " + villa.Name + "isminde " + villa.Area + "m2 büyüklüðünde " + villa.RoomNumber
             + "oda sayýlýdýr. " + "Satýlýk olup fiyatý: " + villa.Price + "Uygundur.";

        if (apartman.IsAvailable)
        {
            Debug.Log(resultApartman);
        }
        if (cabin.IsAvailable)
        {
            Debug.Log(resultCabin);
        }
        if (villa.IsAvailable)
        {
            Debug.Log(resultVilla);
        }
    }
}
