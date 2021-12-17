using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Face : GameManager
{
    public int numero;
    public int prix;
    public FaceEffect effet;

    public Face(int numero,int prix,int numeroVal,ress TypeR)
    {
        numero = numero;
        prix = prix;
        effet = new FaceEffect(numeroVal,TypeR);
    }
}