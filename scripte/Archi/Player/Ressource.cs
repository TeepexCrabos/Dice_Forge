using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ressource
{
    public int Gold { get; set; }
    public int FragmentSolaire { get; set; }
    public int FragmentLunaire { get; set; }
    public int PointVictoire { get; set; }

    public Ressource(int numero)
    {
        switch (numero)
        {
            case 1:
                Gold = 3;
                FragmentSolaire = 0;
                FragmentLunaire = 0;
                PointVictoire = 0;
                break;

            case 2:
                Gold = 2;
                FragmentSolaire = 0;
                FragmentLunaire = 0;
                PointVictoire = 0;
                break;

            case 3:
                Gold = 1;
                FragmentSolaire = 0;
                FragmentLunaire = 0;
                PointVictoire = 0;
                break;

            case 4:
                Gold = 0;
                FragmentSolaire = 0;
                FragmentLunaire = 0;
                PointVictoire = 0;
                break;
        }
        
    }

    public void PlusRessource(int gold,int fragl,int frags,int ptVic)
    {
        Gold = Gold + gold;
        FragmentLunaire = FragmentLunaire + fragl;
        FragmentSolaire = FragmentSolaire + frags;
        PointVictoire = PointVictoire + ptVic;
    }

    public void MoinsRessource(int gold, int fragl, int frags, int ptVic)
    {
        Gold = Gold - gold;
        FragmentLunaire = FragmentLunaire - fragl;
        FragmentSolaire = FragmentSolaire - frags;
        PointVictoire = PointVictoire - ptVic;
    }

}
