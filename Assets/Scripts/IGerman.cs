using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGerman
{
    //İnterfaceslerin fieldları olmaz. Accesmodifierleri olmaz.
     bool IsGerman { get; set; }
     void GermanMakeSell();
}
