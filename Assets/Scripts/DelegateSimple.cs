using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateSimple : MonoBehaviour
{

    [SerializeField] EventSimple _eventSimple;
    public delegate void DelegateSimple1(); // Bu delegate deðer döndürmeyen ve parametre almayan temsilci.
    public delegate void DelegateSimple2(int sayi1, int sayi2); // Bu delegate deðer döndürmeyen ve iki parametre alan bir temsilci.

    //DelegateSimple1 _delegateSimple1;

    DelegateSimple2 _delegateSimple2;
    //EventSimple _eventSimple;

    private void Awake()
    {
        //_eventSimple = FindObjectOfType<EventSimple>(); 

    }
    private void Start()
    {
       
    }
    private void OnEnable()
    {
        _eventSimple.SimpleDelegateEvent += HandleSimpleDelegateEvent;
    }
    private void OnDisable()
    {
        _eventSimple.SimpleDelegateEvent -= HandleSimpleDelegateEvent;
    }

    private void HandleSimpleDelegateEvent(int sayi)
    {
        Debug.Log("tetiklendi..  " + sayi);
    }

    public void UnityEventSimple()
    {
        Debug.Log("Unity event simple tetiklendi.");
    }

    void DelegateSimple1Simple ()
    {
        DelegateSimple1 delegateSimple1 = new DelegateSimple1(ParametreAlmayanDegerDondurmeyenOrnek1);
        delegateSimple1 += ParametreAlmayanDegerDondurmeyenOrnek2;
        delegateSimple1 += ParametreAlmayanDegerDondurmeyenOrnek3;
        delegateSimple1 += ParametreAlmayanDegerDondurmeyenOrnek4;

        delegateSimple1 -= ParametreAlmayanDegerDondurmeyenOrnek4;

        //if (_delegateSimple1 != null)
        //{
        //    _delegateSimple1.Invoke();
        //}

        //_delegateSimple1?.Invoke();  // Yukardakinin kýsa yazým örneðidir.




        delegateSimple1.Invoke();
    }

    void DelegateSimple2Simple()
    {
        _delegateSimple2 = new DelegateSimple2(ParametreAlanDegerDondurmeyenOrnek1);
        _delegateSimple2 += ParametreAlanDegerDondurmeyenOrnek2;
        _delegateSimple2 += ParametreAlanDegerDondurmeyenOrnek3;

        //_delegateSimple2(30, 20);
    }

    void ParametreAlmayanDegerDondurmeyenOrnek1()
    {
        Debug.Log("ParametreAlmayanDegerDondurmeyenOrnek1 calisti.");
    }
    void ParametreAlmayanDegerDondurmeyenOrnek2()
    {
        Debug.Log("ParametreAlmayanDegerDondurmeyenOrnek2 calisti.");
    }
    void ParametreAlmayanDegerDondurmeyenOrnek3()
    {
        Debug.Log("ParametreAlmayanDegerDondurmeyenOrnek3 calisti.");
    }
    void ParametreAlmayanDegerDondurmeyenOrnek4()
    {
        Debug.Log("ParametreAlmayanDegerDondurmeyenOrnek4 calisti.");
    }

    void ParametreAlanDegerDondurmeyenOrnek1(int sayi1, int sayi2)
    {
        Debug.Log(sayi1 + sayi2);
    }
    void ParametreAlanDegerDondurmeyenOrnek2(int sayi1, int sayi2)
    {
        Debug.Log(sayi1 - sayi2);
    }
    void ParametreAlanDegerDondurmeyenOrnek3(int sayi1, int sayi2)
    {
        Debug.Log(sayi1 * sayi2);
    }
}
