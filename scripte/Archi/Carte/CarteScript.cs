using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarteScript : MonoBehaviour
{
    public string NomDeLaCarte;
    public int PrixLunaire;
    public int PrixSolaire;
    public int PtVictoire;
    public int Gold;
    public int lune;
    public int NumeroTypeCarte;
    public int NombreDeCarte = 4;
    public GameObject Halo;
    public GameObject Pbleu;
    public GameObject PNoir;
    public GameObject POrange;
    public GameObject PVert;
    public int Tjoueur;
    public GameObject GameManager;
    public GameObject Place;
    public string choix;
    public int Solaire;
    public GameObject buttonGold;
    public GameObject buttonSoleil;
    public GameObject buttonLune;
    public GameObject buttonVictoire;
    public GameObject sabot1B;
    public GameObject sabot2B;
    public GameObject sabot3B;
    public GameObject sabot4B;
    public GameObject sage1B;
    public GameObject sage2B;
    public GameObject sage3B;
    public GameObject sage4B;
    public GameObject gardienne1B;
    public GameObject gardienne2B;
    public GameObject gardienne3B;
    public GameObject gardienne4B;
    public GameObject CoffreB;
    public GameObject Marteau1B;
    public GameObject Marteau2B;
    public GameObject Marteau3B;
    public GameObject Marteau4B;
    public GameObject sabot1N;
    public GameObject sabot2N;
    public GameObject sabot3N;
    public GameObject sabot4N;
    public GameObject sage1N;
    public GameObject sage2N;
    public GameObject sage3N;
    public GameObject sage4N;
    public GameObject gardienne1N;
    public GameObject gardienne2N;
    public GameObject gardienne3N;
    public GameObject gardienne4N;
    public GameObject CoffreN;
    public GameObject Marteau1N;
    public GameObject Marteau2N;
    public GameObject Marteau3N;
    public GameObject Marteau4N;
    public GameObject sabot1O;
    public GameObject sabot2O;
    public GameObject sabot3O;
    public GameObject sabot4O;
    public GameObject sage1O;
    public GameObject sage2O;
    public GameObject sage3O;
    public GameObject sage4O;
    public GameObject gardienne1O;
    public GameObject gardienne2O;
    public GameObject gardienne3O;
    public GameObject gardienne4O;
    public GameObject CoffreO;
    public GameObject Marteau1O;
    public GameObject Marteau2O;
    public GameObject Marteau3O;
    public GameObject Marteau4O;
    public GameObject sabot1V;
    public GameObject sabot2V;
    public GameObject sabot3V;
    public GameObject sabot4V;
    public GameObject sage1V;
    public GameObject sage2V;
    public GameObject sage3V;
    public GameObject sage4V;
    public GameObject gardienne1V;
    public GameObject gardienne2V;
    public GameObject gardienne3V;
    public GameObject gardienne4V;
    public GameObject CoffreV;
    public GameObject Marteau1V;
    public GameObject Marteau2V;
    public GameObject Marteau3V;
    public GameObject Marteau4V;


    // Start is called before the first frame update
    void Start()
    {
        Carte carte = new Carte(NomDeLaCarte, PrixLunaire, PrixSolaire, PtVictoire, NumeroTypeCarte);
    }

    void Update()
    {
        Tjoueur = GameManager.GetComponent<GameManager>().TourJ;
        if (NombreDeCarte == 0)
        {
            Destroy(this);
        }
    }

    void OnMouseOver()  // quand la souris et sur un quad chengement de texture
    {
        Halo.SetActive(true);
    }

    void OnMouseExit()  // quand la souris n'est plus sur un quad sa revien a la texture davant 
    {
        Halo.SetActive(false);
    }

    void OnMouseDown()
    {
        var a = Pbleu.GetComponent<Transform>().position;
        var b = Place.GetComponent<Transform>().position;
        Debug.Log(a.x + ":" + b.x);
        Debug.Log(a + " : " + b);
        switch (Tjoueur)
        {
            case 1:
                if (Pbleu.GetComponent<PlayerScript>().player.GetFragmentSolaire() >= PrixSolaire && Pbleu.GetComponent<PlayerScript>().player.GetFragmentLunaire() >= PrixLunaire)
                {
                    if (Mathf.Floor(a.x) == Mathf.Floor(b.x) && a.y == b.y)
                    {
                        Debug.Log("acheter");
                        NombreDeCarte = NombreDeCarte - 1;
                        CarteAppliqueB(NomDeLaCarte);
                        GameManager.GetComponent<GameManager>().action = GameManager.GetComponent<GameManager>().action + 1;
                    }
                    else
                    {
                        Debug.Log("pas bon" + Mathf.Floor(a.x) + ":" + Mathf.Floor(b.x));
                    }
                    

                }

                
                break;

            case 2:
                if (PNoir.GetComponent<PlayerScript>().player.GetFragmentSolaire() >= PrixSolaire && PNoir.GetComponent<PlayerScript>().player.GetFragmentLunaire() >= PrixLunaire)
                {
                    NombreDeCarte = -1;
                    Debug.Log("acheter");
                    //CarteAppliqueN(NomDelaCarte);
                    GameManager.GetComponent<GameManager>().action = GameManager.GetComponent<GameManager>().action + 1;
                }
                break;

            case 3:
                if (POrange.GetComponent<PlayerScript>().player.GetFragmentSolaire() >= PrixSolaire && POrange.GetComponent<PlayerScript>().player.GetFragmentLunaire() >= PrixLunaire)
                {
                    NombreDeCarte = -1;
                    Debug.Log("acheter");
                    //CarteAppliqueO(NomDelaCarte);
                    GameManager.GetComponent<GameManager>().action = GameManager.GetComponent<GameManager>().action + 1;
                }
                break;

            case 4:
                if (PVert.GetComponent<PlayerScript>().player.GetFragmentSolaire() >= PrixSolaire && PVert.GetComponent<PlayerScript>().player.GetFragmentLunaire() >= PrixLunaire)
                {
                    NombreDeCarte = -1;
                    Debug.Log("acheter");
                    //CarteAppliqueV(NomDelaCarte);
                    GameManager.GetComponent<GameManager>().action = GameManager.GetComponent<GameManager>().action + 1;
                }
                break;
        }
    }

    public void Choix(string type)
    {
        switch (type)
        {
            case "G/S/L":
                buttonGold.SetActive(true);
                buttonSoleil.SetActive(true);
                buttonLune.SetActive(true);
                break;

            case "G/V":
                buttonGold.SetActive(true);
                buttonVictoire.SetActive(true);
                break;

            case "G/L":
                buttonGold.SetActive(true);
                buttonLune.SetActive(true);

                break;

        }
    }

    public void SelectchoixG()
    {
        choix = "G";
        buttonGold.SetActive(false);
        buttonSoleil.SetActive(false);
        buttonLune.SetActive(false);
        buttonVictoire.SetActive(false);
        if (Tjoueur == 1)
        {
            Pbleu.GetComponent<PlayerScript>().player.goldPlus(Gold);
        }
        if (Tjoueur == 2)
        {
            PNoir.GetComponent<PlayerScript>().player.goldPlus(Gold);
        }

        if (Tjoueur == 3)
        {
            POrange.GetComponent<PlayerScript>().player.goldPlus(Gold);
        }
        if (Tjoueur == 4)
        {
            PVert.GetComponent<PlayerScript>().player.goldPlus(Gold);
        }
    }

    public void SelectchoixF()
    {
        choix = "S";
        buttonGold.SetActive(false);
        buttonSoleil.SetActive(false);
        buttonLune.SetActive(false);
        buttonVictoire.SetActive(false);
        if (Tjoueur == 1)
        {
            Pbleu.GetComponent<PlayerScript>().player.FragementSolairePlus(Solaire);
        }
        if (Tjoueur == 2)
        {
            Pbleu.GetComponent<PlayerScript>().player.FragementSolairePlus(Solaire);
        }
        if (Tjoueur == 3)
        {
            POrange.GetComponent<PlayerScript>().player.FragementSolairePlus(Solaire);
        }
        if (Tjoueur == 4)
        {
            PVert.GetComponent<PlayerScript>().player.FragementSolairePlus(Solaire);
        }
    }
    public void SelectchoixL()
    {
        
        buttonGold.SetActive(false);
        buttonSoleil.SetActive(false);
        buttonLune.SetActive(false);
        buttonVictoire.SetActive(false);
        if (Tjoueur == 1)
        {
            Pbleu.GetComponent<PlayerScript>().player.FragementLunairePlus(lune);
        }
        if (Tjoueur == 2)
        {
            PNoir.GetComponent<PlayerScript>().player.FragementLunairePlus(lune);
        }
        if (Tjoueur == 3)
        {
            POrange.GetComponent<PlayerScript>().player.FragementLunairePlus(lune);
        }
        if (Tjoueur == 4)
        {
            PVert.GetComponent<PlayerScript>().player.FragementLunairePlus(lune);
        }
    }
    
    public void SelectchoixV()
    {
        buttonGold.SetActive(false);
        buttonSoleil.SetActive(false);
        buttonLune.SetActive(false);
        buttonVictoire.SetActive(false);
        if (Tjoueur == 1)
        {
            Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
        }
        if (Tjoueur == 2)
        {
            PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
        }
        if (Tjoueur == 3)
        {
            POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
        }
        if (Tjoueur == 4)
        {
            PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
        }
    }
    

    public void CarteAppliqueB(string Name)
    {
        switch (Name)
        {
        
            case "MARTEAU DU FORGERON":
                if (Marteau1B.activeInHierarchy)
                {
                    if (Marteau2B.activeInHierarchy)
                    {
                        if (Marteau3B.activeInHierarchy)
                        {
                            if (Marteau4B.activeInHierarchy)
                            {

                            }
                            else
                            {
                                Marteau4B.SetActive(true);
                            }
                        }
                        else
                        {
                            Marteau3B.SetActive(true);
                        }
                    }
                    else
                    {
                        Marteau2B.SetActive(true);
                    }
                }
                else
                {
                    Marteau1B.SetActive(true);
                }

                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "COFFRE DU FORGERON":
                CoffreB.SetActive(true);
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA GRANDE OURSE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LES SABOTS D'ARGENT":
                Debug.Log("bob");
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                GameManager.GetComponent<GameManager>().DésBleu1.SetActive(true);
                if (sabot1B.activeInHierarchy)
                {
                    if (sabot2B.activeInHierarchy)
                    {
                        if (sabot3B.activeInHierarchy)
                        {
                            if (sabot4B.activeInHierarchy)
                            {

                            }
                            else
                            {
                                sabot4B.SetActive(true);
                            }
                        }
                        else
                        {
                            sabot3B.SetActive(true);
                        }
                    }
                    else
                    {
                        sabot2B.SetActive(true);
                    }
                }
                else
                {
                    sabot1B.SetActive(true);
                }
                

                break;

            case "LE SANGLIER ACHARNE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LES SATYRES":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "L'ANCIEN":
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                if (sage1B.activeInHierarchy)
                {
                    if (sage2B.activeInHierarchy)
                    {
                        if (sage3B.activeInHierarchy)
                        {
                            if (sage4B.activeInHierarchy)
                            {

                            }
                            else
                            {
                                sage4B.SetActive(true);
                            }
                        }
                        else
                        {
                            sage3B.SetActive(true);
                        }
                    }
                    else
                    {
                        sage2B.SetActive(true);
                    }
                }
                else
                {
                    sage1B.SetActive(true);
                }
                break;

            case "LES HERBES FOLLES":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.goldPlus(Gold);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunairePlus(lune);
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LES AILES DE LA GARDIENNE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Choix("G/S/L");
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                if (gardienne1B.activeInHierarchy)
                {
                    if (gardienne2B.activeInHierarchy)
                    {
                        if (gardienne3B.activeInHierarchy)
                        {
                            if (gardienne4B.activeInHierarchy)
                            {

                            }
                            else
                            {
                                gardienne4B.SetActive(true);
                            }
                        }
                        else
                        {
                            gardienne3B.SetActive(true);
                        }
                    }
                    else
                    {
                        gardienne2B.SetActive(true);
                    }
                }
                else
                {
                    gardienne1B.SetActive(true);
                }
                break;

            case "LA VOILE CELESTE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE MINOTAURE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE BOUCLIER DE LA GARDIENNE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "CERBERE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE PASSEUR":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE CASQUE D'INVISIBILITE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA SENTINELLE":
                 Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA PINCE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA MEDUSE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE TRITON":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE MIROIR ABYSSAL":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "L'ENIGME":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "lE CYCLOPE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "L'HYDRE":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE TYPHON":
                Pbleu.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Pbleu.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;
        }
    }

    public void CarteAppliqueN(string Name)
    {
        switch (Name)
        {

            case "MARTEAU DU FORGERON":
                if (Marteau1N.activeInHierarchy)
                {
                    if (Marteau2N.activeInHierarchy)
                    {
                        if (Marteau3N.activeInHierarchy)
                        {
                            if (Marteau4N.activeInHierarchy)
                            {

                            }
                            else
                            {
                                Marteau4N.SetActive(true);
                            }
                        }
                        else
                        {
                            Marteau3N.SetActive(true);
                        }
                    }
                    else
                    {
                        Marteau2N.SetActive(true);
                    }
                }
                else
                {
                    Marteau1N.SetActive(true);
                }

                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "COFFRE DU FORGERON":
                CoffreN.SetActive(true);
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA GRANDE OURSE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LES SABOTS D'ARGENT":
                Debug.Log("bob");
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                GameManager.GetComponent<GameManager>().DésNoir1.SetActive(true);
                if (sabot1N.activeInHierarchy)
                {
                    if (sabot2N.activeInHierarchy)
                    {
                        if (sabot3N.activeInHierarchy)
                        {
                            if (sabot4N.activeInHierarchy)
                            {

                            }
                            else
                            {
                                sabot4N.SetActive(true);
                            }
                        }
                        else
                        {
                            sabot3N.SetActive(true);
                        }
                    }
                    else
                    {
                        sabot2N.SetActive(true);
                    }
                }
                else
                {
                    sabot1N.SetActive(true);
                }


                break;

            case "LE SANGLIER ACHARNE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LES SATYRES":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "L'ANCIEN":
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                if (sage1N.activeInHierarchy)
                {
                    if (sage2N.activeInHierarchy)
                    {
                        if (sage3N.activeInHierarchy)
                        {
                            if (sage4N.activeInHierarchy)
                            {

                            }
                            else
                            {
                                sage4N.SetActive(true);
                            }
                        }
                        else
                        {
                            sage3N.SetActive(true);
                        }
                    }
                    else
                    {
                        sage2N.SetActive(true);
                    }
                }
                else
                {
                    sage1N.SetActive(true);
                }
                break;

            case "LES HERBES FOLLES":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.goldPlus(Gold);
                PNoir.GetComponent<PlayerScript>().player.FragementLunairePlus(lune);
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LES AILES DE LA GARDIENNE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Choix("G/S/L");
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                if (gardienne1N.activeInHierarchy)
                {
                    if (gardienne2N.activeInHierarchy)
                    {
                        if (gardienne3N.activeInHierarchy)
                        {
                            if (gardienne4N.activeInHierarchy)
                            {

                            }
                            else
                            {
                                gardienne4N.SetActive(true);
                            }
                        }
                        else
                        {
                            gardienne3N.SetActive(true);
                        }
                    }
                    else
                    {
                        gardienne2N.SetActive(true);
                    }
                }
                else
                {
                    gardienne1N.SetActive(true);
                }
                break;

            case "LA VOILE CELESTE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE MINOTAURE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE BOUCLIER DE LA GARDIENNE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "CERBERE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE PASSEUR":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE CASQUE D'INVISIBILITE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA SENTINELLE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA PINCE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA MEDUSE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE TRITON":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE MIROIR ABYSSAL":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "L'ENIGME":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "lE CYCLOPE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "L'HYDRE":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE TYPHON":
                PNoir.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PNoir.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;
        }
    }

    public void CarteAppliqueO(string Name)
    {
        switch (Name)
        {

            case "MARTEAU DU FORGERON":
                if (Marteau1O.activeInHierarchy)
                {
                    if (Marteau2O.activeInHierarchy)
                    {
                        if (Marteau3O.activeInHierarchy)
                        {
                            if (Marteau4O.activeInHierarchy)
                            {

                            }
                            else
                            {
                                Marteau4O.SetActive(true);
                            }
                        }
                        else
                        {
                            Marteau3O.SetActive(true);
                        }
                    }
                    else
                    {
                        Marteau2O.SetActive(true);
                    }
                }
                else
                {
                    Marteau1O.SetActive(true);
                }

                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "COFFRE DU FORGERON":
                CoffreO.SetActive(true);
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA GRANDE OURSE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LES SABOTS D'ARGENT":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                GameManager.GetComponent<GameManager>().DésOrange1.SetActive(true);
                if (sabot1O.activeInHierarchy)
                {
                    if (sabot2O.activeInHierarchy)
                    {
                        if (sabot3O.activeInHierarchy)
                        {
                            if (sabot4O.activeInHierarchy)
                            {

                            }
                            else
                            {
                                sabot4O.SetActive(true);
                            }
                        }
                        else
                        {
                            sabot3O.SetActive(true);
                        }
                    }
                    else
                    {
                        sabot2O.SetActive(true);
                    }
                }
                else
                {
                    sabot1O.SetActive(true);
                }


                break;

            case "LE SANGLIER ACHARNE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LES SATYRES":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "L'ANCIEN":
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                if (sage1O.activeInHierarchy)
                {
                    if (sage2O.activeInHierarchy)
                    {
                        if (sage3O.activeInHierarchy)
                        {
                            if (sage4O.activeInHierarchy)
                            {

                            }
                            else
                            {
                                sage4O.SetActive(true);
                            }
                        }
                        else
                        {
                            sage3O.SetActive(true);
                        }
                    }
                    else
                    {
                        sage2O.SetActive(true);
                    }
                }
                else
                {
                    sage1O.SetActive(true);
                }
                break;

            case "LES HERBES FOLLES":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.goldPlus(Gold);
                POrange.GetComponent<PlayerScript>().player.FragementLunairePlus(lune);
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LES AILES DE LA GARDIENNE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Choix("G/S/L");
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                if (gardienne1O.activeInHierarchy)
                {
                    if (gardienne2O.activeInHierarchy)
                    {
                        if (gardienne3O.activeInHierarchy)
                        {
                            if (gardienne4O.activeInHierarchy)
                            {

                            }
                            else
                            {
                                gardienne4O.SetActive(true);
                            }
                        }
                        else
                        {
                            gardienne3O.SetActive(true);
                        }
                    }
                    else
                    {
                        gardienne2O.SetActive(true);
                    }
                }
                else
                {
                    gardienne1O.SetActive(true);
                }
                break;

            case "LA VOILE CELESTE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE MINOTAURE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE BOUCLIER DE LA GARDIENNE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "CERBERE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE PASSEUR":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE CASQUE D'INVISIBILITE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA SENTINELLE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA PINCE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA MEDUSE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE TRITON":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE MIROIR ABYSSAL":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "L'ENIGME":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "lE CYCLOPE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "L'HYDRE":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE TYPHON":
                POrange.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                POrange.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;
        }
    }

    public void CarteAppliqueV(string Name)
    {
        switch (Name)
        {

            case "MARTEAU DU FORGERON":
                if (Marteau1V.activeInHierarchy)
                {
                    if (Marteau2V.activeInHierarchy)
                    {
                        if (Marteau3V.activeInHierarchy)
                        {
                            if (Marteau4V.activeInHierarchy)
                            {

                            }
                            else
                            {
                                Marteau4V.SetActive(true);
                            }
                        }
                        else
                        {
                            Marteau3V.SetActive(true);
                        }
                    }
                    else
                    {
                        Marteau2V.SetActive(true);
                    }
                }
                else
                {
                    Marteau1V.SetActive(true);
                }

                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "COFFRE DU FORGERON":
                CoffreV.SetActive(true);
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA GRANDE OURSE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LES SABOTS D'ARGENT":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                GameManager.GetComponent<GameManager>().DésVert1.SetActive(true);
                if (sabot1V.activeInHierarchy)
                {
                    if (sabot2V.activeInHierarchy)
                    {
                        if (sabot3V.activeInHierarchy)
                        {
                            if (sabot4V.activeInHierarchy)
                            {

                            }
                            else
                            {
                                sabot4V.SetActive(true);
                            }
                        }
                        else
                        {
                            sabot3V.SetActive(true);
                        }
                    }
                    else
                    {
                        sabot2V.SetActive(true);
                    }
                }
                else
                {
                    sabot1V.SetActive(true);
                }


                break;

            case "LE SANGLIER ACHARNE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LES SATYRES":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "L'ANCIEN":
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                if (sage1V.activeInHierarchy)
                {
                    if (sage2V.activeInHierarchy)
                    {
                        if (sage3V.activeInHierarchy)
                        {
                            if (sage4V.activeInHierarchy)
                            {

                            }
                            else
                            {
                                sage4V.SetActive(true);
                            }
                        }
                        else
                        {
                            sage3V.SetActive(true);
                        }
                    }
                    else
                    {
                        sage2V.SetActive(true);
                    }
                }
                else
                {
                    sage1V.SetActive(true);
                }
                break;

            case "LES HERBES FOLLES":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.goldPlus(Gold);
                PVert.GetComponent<PlayerScript>().player.FragementLunairePlus(lune);
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LES AILES DE LA GARDIENNE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                Choix("G/S/L");
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                if (gardienne1V.activeInHierarchy)
                {
                    if (gardienne2V.activeInHierarchy)
                    {
                        if (gardienne3V.activeInHierarchy)
                        {
                            if (gardienne4V.activeInHierarchy)
                            {

                            }
                            else
                            {
                                gardienne4V.SetActive(true);
                            }
                        }
                        else
                        {
                            gardienne3V.SetActive(true);
                        }
                    }
                    else
                    {
                        gardienne2V.SetActive(true);
                    }
                }
                else
                {
                    gardienne1V.SetActive(true);
                }
                break;

            case "LA VOILE CELESTE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE MINOTAURE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE BOUCLIER DE LA GARDIENNE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "CERBERE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE PASSEUR":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE CASQUE D'INVISIBILITE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA SENTINELLE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA PINCE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LA MEDUSE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE TRITON":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "LE MIROIR ABYSSAL":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "L'ENIGME":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "lE CYCLOPE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementSolaireMoins(PrixSolaire);
                break;

            case "L'HYDRE":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;

            case "LE TYPHON":
                PVert.GetComponent<PlayerScript>().player.PointVictoirePlus(PtVictoire);
                PVert.GetComponent<PlayerScript>().player.FragementLunaireMoins(PrixLunaire);
                break;
        }
    }

}
