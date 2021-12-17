using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dés
{
    public int numero;
    public List<GameObject> Faces;

    public Dés(int numero)
    {
        numero = numero;
        Faces = new List<GameObject>();
    }

    public void Lancer()
    {

        int entierUnChiffre = Random.Range(1, 6);

        if (entierUnChiffre == 1)
        {
            //Resultat(Faces[0]);
        }

        if (entierUnChiffre == 2)
        {
           // Resultat(Faces[1]);
        }

        if (entierUnChiffre == 3)
        {
            //Resultat(Faces[2]);
        }

        if (entierUnChiffre == 4)
        {
            //Resultat(Faces[3]);
        }

        if (entierUnChiffre == 5)
        {
            //Resultat(Faces[4]);
        }

        if (entierUnChiffre == 6)
        {
           //Resultat(Faces[5]);
        }

    }
/*
    public void Resultat(GameObject face)
    {
        switch(face.GetComponent<FaceScript>().type)
        {
            case "G":
               Player.goldPlus(face.GetComponent<FaceScript>().valeurG);
            break;
            case "G+V+S+L":
                Player.goldPlus(face.GetComponent<FaceScript>().valeurG);
                Player.FragementSolairePlus(face.GetComponent<FaceScript>().valeurS);
                Player.PointVictoirePlus(face.GetComponent<FaceScript>().valeurV);
                Player.FragementLunairePlus(face.GetComponent<FaceScript>().valeurL);
            break;
            case "G/S/L":
                string choix = RetourChoix(face.GetComponent<FaceScript>().type);
            break;
            case "G/V":

                break;
            case "G+L":
                Player.goldPlus(face.GetComponent<FaceScript>().valeurG);
                Player.FragementLunairePlus(face.GetComponent<FaceScript>().valeurL);
            break;


            case "S":
                Player.FragementSolairePlus(face.GetComponent<FaceScript>().valeurS);
            break;


            case "L":
                Player.FragementLunairePlus(face.GetComponent<FaceScript>().valeurL);
            break;


            case "V":
                Player.PointVictoirePlus(face.GetComponent<FaceScript>().valeurV);
            break;
            case "V+L":
                Player.PointVictoirePlus(face.GetComponent<FaceScript>().valeurV);
                Player.FragementLunairePlus(face.GetComponent<FaceScript>().valeurL);

            break;
            case "V+S":
                Player.PointVictoirePlus(face.GetComponent<FaceScript>().valeurV);
                Player.FragementSolairePlus(face.GetComponent<FaceScript>().valeurS);

            break;


            case "ChoixFaceEnemie":

                break;


            case "BGJ":

                break;
            case "BGV":

                break;
            case "BGR":

                break;
            case "BGB":

                break;


            case "Sanctuaire":

                break;


            case "CB":

                break;
            case "CO":

                break;
            case "CV":

                break;
            case "CJ":

                break;



            case "*3":

                break;
        }

    }
*/
}
