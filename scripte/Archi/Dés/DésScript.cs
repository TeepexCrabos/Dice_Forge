using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DésScript : MonoBehaviour
{
    public GameObject Dés;
    public int numero;
    public GameObject face1;
    public GameObject face2;
    public GameObject face3;
    public GameObject face4;
    public GameObject face5;
    public GameObject face6;
    public GameObject faceWin;
    public Vector3 position;
    public int face;
    public int Force = 200;
    public Rigidbody rgbd;
    public float x;
    public float y;
    public float z;
    public GameObject GameManager;
    public GameObject Pion;
    public string choix;
    public GameObject buttonGold;
    public GameObject buttonSoleil;
    public GameObject buttonLune;
    public GameObject buttonVictoire;
    
    int entierUnChiffre;

    // Start is called before the first frame update
    void Start()
    {
        Dés Dé = new Dés(numero);
        rgbd = GetComponent<Rigidbody>();
        /*Dé.Faces[0] = face1;
        Dé.Faces[1] = face2;
        Dé.Faces[2] = face3;
        Dé.Faces[3] = face4;
        Dé.Faces[4] = face5;
        Dé.Faces[5] = face6;*/

    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1") && rgbd.velocity.magnitude == 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("gooooooooooooooooo");
                rgbd.AddForce(hit.point * Force);
                rgbd.rotation = Random.rotation;
            }
            StartCoroutine(Wait(10.0f));
            
            
        }

    }

    IEnumerator Wait(float Time)
    {
        yield return new WaitForSeconds(Time);
        faceWin = face1;

        if (faceWin.GetComponent<Transform>().position.y < face2.GetComponent<Transform>().position.y)
        {
            faceWin = face2;
        }

        if (faceWin.GetComponent<Transform>().position.y < face3.GetComponent<Transform>().position.y)
        {
            faceWin = face3;
        }

        if (faceWin.GetComponent<Transform>().position.y < face4.GetComponent<Transform>().position.y)
        {
            faceWin = face4;
        }

        if (faceWin.GetComponent<Transform>().position.y < face5.GetComponent<Transform>().position.y)
        {
            faceWin = face5;
        }

        if (faceWin.GetComponent<Transform>().position.y < face6.GetComponent<Transform>().position.y)
        {
            faceWin = face6;
        }
        Resultat(faceWin);
        Dés.SetActive(false);

    }
    
    

    public void Resultat(GameObject faceWin)
    {
        switch (faceWin.GetComponent<FaceScript>().type)
        {
            case "G":
                Pion.GetComponent<PlayerScript>().player.goldPlus(faceWin.GetComponent<FaceScript>().valeurG);
                break;
            case "G+V+S+L":
                Pion.GetComponent<PlayerScript>().player.goldPlus(faceWin.GetComponent<FaceScript>().valeurG);
                Pion.GetComponent<PlayerScript>().player.FragementSolairePlus(faceWin.GetComponent<FaceScript>().valeurS);
                Pion.GetComponent<PlayerScript>().player.PointVictoirePlus(faceWin.GetComponent<FaceScript>().valeurV);
                Pion.GetComponent<PlayerScript>().player.FragementLunairePlus(faceWin.GetComponent<FaceScript>().valeurL);
                break;
            case "G/S/L":
                choix = RetourChoix(faceWin.GetComponent<FaceScript>().type);
                break;
            case "G/V":

                break;
            case "G+L":
                Pion.GetComponent<PlayerScript>().player.goldPlus(faceWin.GetComponent<FaceScript>().valeurG);
                Pion.GetComponent<PlayerScript>().player.FragementLunairePlus(faceWin.GetComponent<FaceScript>().valeurL);
                break;


            case "S":
                Pion.GetComponent<PlayerScript>().player.FragementSolairePlus(faceWin.GetComponent<FaceScript>().valeurS);
                break;


            case "L":
                Pion.GetComponent<PlayerScript>().player.FragementLunairePlus(faceWin.GetComponent<FaceScript>().valeurL);
                break;


            case "V":
                Pion.GetComponent<PlayerScript>().player.PointVictoirePlus(faceWin.GetComponent<FaceScript>().valeurV);
                break;
            case "V+L":
                Pion.GetComponent<PlayerScript>().player.PointVictoirePlus(faceWin.GetComponent<FaceScript>().valeurV);
                Pion.GetComponent<PlayerScript>().player.FragementLunairePlus(faceWin.GetComponent<FaceScript>().valeurL);

                break;
            case "V+S":
                Pion.GetComponent<PlayerScript>().player.PointVictoirePlus(faceWin.GetComponent<FaceScript>().valeurV);
                Pion.GetComponent<PlayerScript>().player.FragementSolairePlus(faceWin.GetComponent<FaceScript>().valeurS);

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

    public string RetourChoix(string type)
    {
        switch (type)
        {
            case "G/S/L":
                //buttonGold.SetActive(true);
                //buttonSoleil.SetActive(true);
                //buttonLune.SetActive(true);
                break;

            case "G/V":
                //buttonGold.SetActive(true);
                //buttonVictoire.SetActive(true);
                break;

                
        }
        return choix;
    }

    public void SelectchoixG()
    {
        choix = "G";
        //buttonGold.SetActive(false);
        //buttonSoleil.SetActive(false);
        //buttonLune.SetActive(false);
        //buttonVictoire.SetActive(false);
    }
    public void SelectchoixF()
    {
        choix = "S";
        //buttonGold.SetActive(false);
        //buttonSoleil.SetActive(false);
        //buttonLune.SetActive(false);
        //buttonVictoire.SetActive(false);
    }
    public void SelectchoixL()
    {
        choix = "L";
        //buttonGold.SetActive(false);
        //buttonSoleil.SetActive(false);
        //buttonLune.SetActive(false);
        //buttonVictoire.SetActive(false);
    }
    public void SelectchoixV()
    {
        choix = "V";
        //buttonGold.SetActive(false);
        //buttonSoleil.SetActive(false);
        //buttonLune.SetActive(false);
        //buttonVictoire.SetActive(false);
    }

}

