using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingeltonObject : MonoBehaviour
{
    public static SingeltonObject Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        //NormalClassSingeltonSimple normalClassSingeltonSimple1 = new NormalClassSingeltonSimple();
        //NormalClassSingeltonSimple normalClassSingeltonSimple2 = new NormalClassSingeltonSimple();
        //NormalClassSingeltonSimple normalClassSingeltonSimple3 = new NormalClassSingeltonSimple();
        //NormalClassSingeltonSimple normalClassSingeltonSimple4 = new NormalClassSingeltonSimple();

        NormalClassSingeltonSimple normalClassSingeltonSimple1 = NormalClassSingeltonSimple.Instance();
        NormalClassSingeltonSimple normalClassSingeltonSimple2 = NormalClassSingeltonSimple.Instance();
        NormalClassSingeltonSimple normalClassSingeltonSimple3 = NormalClassSingeltonSimple.Instance();
        NormalClassSingeltonSimple normalClassSingeltonSimple4 = NormalClassSingeltonSimple.Instance();


    }

    public void SingeltonObjectMethod()
    {
        Debug.Log("Singelton object method çalýþtý.");
    }
}


class NormalClassSingeltonSimple
{
    private static NormalClassSingeltonSimple _instance;
    private NormalClassSingeltonSimple()
    {

    }

    public static NormalClassSingeltonSimple Instance()
    {
        if (_instance == null)
        {
            _instance = new NormalClassSingeltonSimple();
        }
        return _instance;
    }
}