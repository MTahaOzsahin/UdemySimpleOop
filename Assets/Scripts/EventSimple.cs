using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSimple : MonoBehaviour
{

    public UnityEvent unityEvent;


    //public delegate void SimpleDelegate();
    //public event SimpleDelegate SimpleDelegateEvent;



    //public event Action SimpleDelegateEvent;     Yukarda yazanýn tek seferde yapabilmemiz saðlar.
    //public event Action<int,int> SimpleDelegateEvent;      Parametre kullanmak istersek böyle yazýlabilir. Hala deðer döndürmez.
    //public event Func<int, int, string> SimpleDelegateEvent;     Deðer de döndürmesini istersek ise böyle yazarýz.
    public event System.Action<int> SimpleDelegateEvent;  //Ayný mantýk.


    int _sayi;
    private void Awake()
    {
       
    }
    private void OnEnable()
    {
        _sayi++;
        SimpleDelegateEvent?.Invoke(_sayi);
        unityEvent?.Invoke();
        SingeltonObject.Instance.SingeltonObjectMethod();
    }
}
