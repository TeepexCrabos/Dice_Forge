using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player  
{
    public string nom;
    public int numero;
    public Dés De1;
    public Dés De2;
    public List<Carte> Carte;
    public Ressource inventaire { get; set; }

    public Player(string Nom,int numero)
    {
        nom=Nom;
        numero = numero;
        De1 = new Dés(1);
        De2 = new Dés(2);
        Carte = new List<Carte>();
        inventaire = new Ressource(numero);
    }

    public void goldPlus(int Nb)
    {
        inventaire.Gold += Nb;
    }

    public void FragementSolairePlus(int Nb)
    {
        inventaire.FragmentSolaire += Nb;
    }

    public void FragementLunairePlus(int Nb)
    {
        inventaire.FragmentLunaire += Nb;
    }

    public void PointVictoirePlus(int Nb)
    {
        inventaire.PointVictoire += Nb;
    }

    public void goldMoins(int Nb)
    {
        inventaire.Gold -= Nb;
    }

    public void FragementSolaireMoins(int Nb)
    {
        inventaire.FragmentSolaire -= Nb;
    }

    public void FragementLunaireMoins(int Nb)
    {
        inventaire.FragmentLunaire -= Nb;
    }

    public void PointVictoireMoins(int Nb)
    {
        inventaire.PointVictoire -= Nb;
    }

    public int GetGold()
    {
        return inventaire.Gold;
    }

    public int GetFragmentSolaire()
    {
        return inventaire.FragmentSolaire;
    }

    public int GetFragmentLunaire()
    {
        return inventaire.FragmentLunaire;
    }

    public int GetPointVictoire()
    {
        return inventaire.PointVictoire;
    }
}
