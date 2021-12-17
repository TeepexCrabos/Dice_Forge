using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectScript: MonoBehaviour
{
    public GameObject Halo;
    public GameObject Pbleu;
    public GameObject PNoir;
    public GameObject POrange;
    public GameObject PVert;
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
                    Debug.Log("acheter");
                }
                Debug.Log("pas assez");
                break;

            case 2:
                if (PNoir.GetComponent<PlayerScript>().player.GetGold() >= prix)
                {
                    Debug.Log("acheter");
                }
                break;

            case 3:
                if (POrange.GetComponent<PlayerScript>().player.GetGold() >= prix)
                {
                    Debug.Log("acheter");
                }
                break;

            case 4:
                if (PVert.GetComponent<PlayerScript>().player.GetGold() >= prix)
                {
                    Debug.Log("acheter");
                }
                break;
        }
    }
}
