using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceScript : MonoBehaviour
{
    public GameObject Halo;
    public GameObject Pbleu;
    public GameObject PNoir;
    public GameObject POrange;
    public GameObject PVert;
    public string NomDelaface;
    public string type;
    public int valeurV;
    public int valeurG;
    public int valeurS;
    public int valeurL;
    public int prix;
    public int Tjoueur;
    public GameObject GameManager;
    // Start is called before the first frame update
    void Update()
    {
        Tjoueur = GameManager.GetComponent<GameManager>().TourJ;
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
        switch (Tjoueur)
        {
            case 1:
                if (Pbleu.GetComponent<PlayerScript>().player.GetGold() >= prix)
                {
                    FaceAppliqueB();
                    GameManager.GetComponent<GameManager>().action = GameManager.GetComponent<GameManager>().action + 1;
                }
                
                break;

            case 2:
                if (PNoir.GetComponent<PlayerScript>().player.GetGold() >= prix)
                {
                    //FaceAppliqueN(NomDelaface);
                    GameManager.GetComponent<GameManager>().action = GameManager.GetComponent<GameManager>().action + 1;
                }
                
                break;

            case 3:
                if (POrange.GetComponent<PlayerScript>().player.GetGold() >= prix)
                {
                    //FaceAppliqueO(NomDelaface);
                    GameManager.GetComponent<GameManager>().action = GameManager.GetComponent<GameManager>().action + 1;
                }
                
                break;

            case 4:
                if (PVert.GetComponent<PlayerScript>().player.GetGold() >= prix)
                {
                    //FaceAppliqueV(NomDelaface);
                    GameManager.GetComponent<GameManager>().action = GameManager.GetComponent<GameManager>().action + 1;
                }
                
                break;
        }
    }

    public void FaceAppliqueB()
    {
      Pbleu.GetComponent<PlayerScript>().player.goldMoins(prix);
                  
    }
}
