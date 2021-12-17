using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public string nom;
    public int numero;
    public Player player { get; set; }


    public int Gold;
    public int Solaire;
    public int Lunaire;
    public int Victoire;
    public int VictoireD = 0;

    public GameObject GoldP;
    public GameObject SolaireP;
    public GameObject LunaireP;
    public GameObject PointVictoireP;
    public GameObject PointVictoireDizaineP;

    public GameObject PG0;
    public GameObject PG1;
    public GameObject PG2;
    public GameObject PG3;
    public GameObject PG4;
    public GameObject PG5;
    public GameObject PG6;
    public GameObject PG7;
    public GameObject PG8;
    public GameObject PG9;
    public GameObject PG10;
    public GameObject PG11;
    public GameObject PG12;

    public GameObject PS0;
    public GameObject PS1;
    public GameObject PS2;
    public GameObject PS3;
    public GameObject PS4;
    public GameObject PS5;
    public GameObject PS6;
 

    public GameObject PL0;
    public GameObject PL1;
    public GameObject PL2;
    public GameObject PL3;
    public GameObject PL4;
    public GameObject PL5;
    public GameObject PL6;


    public GameObject PV0;
    public GameObject PV1;
    public GameObject PV2;
    public GameObject PV3;
    public GameObject PV4;
    public GameObject PV5;
    public GameObject PV6;
    public GameObject PV7;
    public GameObject PV8;
    public GameObject PV9;
    

    public GameObject PVD0;
    public GameObject PVD1;
    public GameObject PVD2;
    public GameObject PVD3;
    public GameObject PVD4;
    public GameObject PVD5;
    public GameObject PVD6;
    public GameObject PVD7;
    public GameObject PVD8;
    public GameObject PVD9;
    



    // Start is called before the first frame update
    void Start()
    {
       player = new Player(nom, numero);
       //GameManager.Instance.players.add(player);
    }

    // Update is called once per frame
    void Update()
    {
        Solaire = player.GetFragmentSolaire();
        Gold = player.GetGold();
        Victoire =  player.GetPointVictoire();
        Lunaire = player.GetFragmentLunaire();

        if(Gold > 12)
        {
            player.inventaire.Gold = 12;
        }
        if (Solaire > 6)
        {
            player.inventaire.FragmentSolaire = 6;
        }
        if (Lunaire > 6)
        {
            player.inventaire.FragmentLunaire = 6;
        }
        while (Victoire > 9)
        {
                Victoire = Victoire - 10;
                VictoireD = VictoireD + 1;
        } 
        Lunaire = player.GetFragmentLunaire();

        MAJ();
    }

    public void MAJ()
    {
        switch (Solaire)
        {
            case 0:
                SolaireP.GetComponent<RectTransform>().position = PS0.GetComponent<RectTransform>().position;
                break;
            case 1:
                SolaireP.GetComponent<RectTransform>().position = PS1.GetComponent<RectTransform>().position;
                break;
            case 2:
                SolaireP.GetComponent<RectTransform>().position = PS2.GetComponent<RectTransform>().position;
                break;
            case 3:
                SolaireP.GetComponent<RectTransform>().position = PS3.GetComponent<RectTransform>().position;
                break;
            case 4:
                SolaireP.GetComponent<RectTransform>().position = PS4.GetComponent<RectTransform>().position;
                break;
            case 5:
                SolaireP.GetComponent<RectTransform>().position = PS5.GetComponent<RectTransform>().position;
                break;
            case 6:
                SolaireP.GetComponent<RectTransform>().position = PS6.GetComponent<RectTransform>().position;
                break;
            
        }

        switch (Lunaire)
        {
            case 0:
                LunaireP.GetComponent<RectTransform>().position = PL0.GetComponent<RectTransform>().position;
                break;
            case 1:
                 LunaireP.GetComponent<RectTransform>().position = PL1.GetComponent<RectTransform>().position;
                break;
            case 2:
                LunaireP.GetComponent<RectTransform>().position = PL2.GetComponent<RectTransform>().position;
                break;
            case 3:
                LunaireP.GetComponent<RectTransform>().position = PL3.GetComponent<RectTransform>().position;
                break;
            case 4:
                LunaireP.GetComponent<RectTransform>().position = PL4.GetComponent<RectTransform>().position;
                break;
            case 5:
                LunaireP.GetComponent<RectTransform>().position = PL5.GetComponent<RectTransform>().position;
                break;
            case 6:
                LunaireP.GetComponent<RectTransform>().position = PL6.GetComponent<RectTransform>().position;
                break;
            
        }

        switch (Gold)
        {
            case 0:
                GoldP.GetComponent<RectTransform>().position = PG0.GetComponent<RectTransform>().position;
                break;
            case 1:
                GoldP.GetComponent<RectTransform>().position = PG1.GetComponent<RectTransform>().position;
                break;
            case 2:
                GoldP.GetComponent<RectTransform>().position = PG2.GetComponent<RectTransform>().position;
                break;
            case 3:
                GoldP.GetComponent<RectTransform>().position = PG3.GetComponent<RectTransform>().position;
                break;
            case 4:
                GoldP.GetComponent<RectTransform>().position = PG4.GetComponent<RectTransform>().position;
                break;
            case 5:
                GoldP.GetComponent<RectTransform>().position = PG5.GetComponent<RectTransform>().position;
                break;
            case 6:
                GoldP.GetComponent<RectTransform>().position = PG6.GetComponent<RectTransform>().position;
                break;
            case 7:
                GoldP.GetComponent<RectTransform>().position = PG7.GetComponent<RectTransform>().position;
                break;
            case 8:
                GoldP.GetComponent<RectTransform>().position = PG8.GetComponent<RectTransform>().position;
                break;
            case 9:
                GoldP.GetComponent<RectTransform>().position = PG9.GetComponent<RectTransform>().position;
                break;
            case 10:
                GoldP.GetComponent<RectTransform>().position = PG10.GetComponent<RectTransform>().position;
                break;
            case 11:
                GoldP.GetComponent<RectTransform>().position = PG11.GetComponent<RectTransform>().position;
                break;
            case 12:
                GoldP.GetComponent<RectTransform>().position = PG12.GetComponent<RectTransform>().position;
                break;
        }

        switch (Victoire)
        {
            case 0:
                PointVictoireP.GetComponent<RectTransform>().position = PV0.GetComponent<RectTransform>().position;
                break;
            case 1:
                PointVictoireP.GetComponent<RectTransform>().position = PV1.GetComponent<RectTransform>().position;
                break;
            case 2:
                PointVictoireP.GetComponent<RectTransform>().position = PV2.GetComponent<RectTransform>().position;
                break;
            case 3:
                PointVictoireP.GetComponent<RectTransform>().position = PV3.GetComponent<RectTransform>().position;
                break;
            case 4:
                PointVictoireP.GetComponent<RectTransform>().position = PV4.GetComponent<RectTransform>().position;
                break;
            case 5:
                PointVictoireP.GetComponent<RectTransform>().position = PV5.GetComponent<RectTransform>().position;
                break;
            case 6:
                PointVictoireP.GetComponent<RectTransform>().position = PV6.GetComponent<RectTransform>().position;
                break;
            case 7:
                PointVictoireP.GetComponent<RectTransform>().position = PV7.GetComponent<RectTransform>().position;
                break;
            case 8:
                PointVictoireP.GetComponent<RectTransform>().position = PV8.GetComponent<RectTransform>().position;
                break;
            case 9:
                PointVictoireP.GetComponent<RectTransform>().position = PV9.GetComponent<RectTransform>().position;
                break;
            
           
        }

        switch (VictoireD)
        {
            case 0:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD0.GetComponent<RectTransform>().position;
                break;
            case 1:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD1.GetComponent<RectTransform>().position;
                break;
            case 2:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD2.GetComponent<RectTransform>().position;
                break;
            case 3:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD3.GetComponent<RectTransform>().position;
                break;
            case 4:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD4.GetComponent<RectTransform>().position;
                break;
            case 5:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD5.GetComponent<RectTransform>().position;
                break;
            case 6:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD6.GetComponent<RectTransform>().position;
                break;
            case 7:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD7.GetComponent<RectTransform>().position;
                break;
            case 8:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD8.GetComponent<RectTransform>().position;
                break;
            case 9:
                PointVictoireDizaineP.GetComponent<RectTransform>().position = PVD9.GetComponent<RectTransform>().position;
                break;

        }
    }

}
