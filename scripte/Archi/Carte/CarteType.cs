using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CarteType
{
    public string Desc;
    

    public CarteType(int numero)
    {
        switch (numero)
        {
            case 1:
                Desc = "renfort";
                break;
            case 2:
                Desc = "immediat";
                break;
            case 3:
                Desc = "automatique";
                break;
            case 0:
                Desc = "pas d'effet";
                break;
        }
        
    }

}
