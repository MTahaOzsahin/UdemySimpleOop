using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People 
{
    #region Encapsulation
    //string _firstName;
    //string _lastName;
    //int _age;

    //public string FirstName   //bunlar birer old propertdir.
    //{
    //    get { return _firstName; }
    //    set { _firstName = value; }
    //}
    //public string LastName { get; set; }  // Bu da bir new propertdir. B�yle yaz�l�r ki sonras�nda capsullemek istersek a��p yazabiliriz sorunsuz.
    //                                      // �stemez isek b�yle durabilir

    //public int Age
    //{
    //    get { return _age; }
    //    set
    //    {
    //        if (value < 1 || value > 100)
    //        {
    //            _age = 18;
    //            throw new System.Exception("Hatal� ya� giri�i");

    //        }
    //        else
    //            _age = value;
    //    }
    //} 
    #endregion

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
}
