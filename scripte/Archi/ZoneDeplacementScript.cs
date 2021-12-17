using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDeplacementScript : MonoBehaviour
{
    public GameObject Halo;
    public GameObject Pbleu;
    public GameObject PNoir;
    public GameObject POrange;
    public GameObject PVert;
    public int Tjoueur;
    public GameObject GameManager;

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
                Pbleu.GetComponent<Transform>().position = GetComponent<Transform>().position;
                break;

            case 2:
                PNoir.GetComponent<Transform>().position = GetComponent<Transform>().position;
                break;

            case 3:
                POrange.GetComponent<Transform>().position = GetComponent<Transform>().position;
                break;

            case 4:
                PVert.GetComponent<Transform>().position = GetComponent<Transform>().position;
                break;
        }
    }
}
