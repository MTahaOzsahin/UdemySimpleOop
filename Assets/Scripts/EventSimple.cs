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



    //public event Action SimpleDelegateEvent;     Yukarda yazan�n tek seferde yapabilmemiz sa�lar.
    //public event Action<int,int> SimpleDelegateEvent;      Parametre kullanmak istersek b�yle yaz�labilir. Hala de�er d�nd�rmez.
    //public event Func<int, int, string> SimpleDelegateEvent;     De�er de d�nd�rmesini istersek ise b�yle yazar�z.
    public event System.Action<int> SimpleDelegateEvent;  //Ayn� mant�k.


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
