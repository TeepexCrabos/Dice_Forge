using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.UI;

public class GameManager : MonoBehaviour
{
    public enum ress
    {
        Gold,
        FragL,
        FragS,
        PtVic
    }



    public GameObject CameraMain;
    public GameObject CameraTop;
    public GameObject TempleCamera;

    public GameObject canvasJ1;
    public GameObject canvasJ2;
    public GameObject canvasJ3;
    public GameObject canvasJ4;

    public int tour;
    public int TourJ;
    public int NbJoueur;
    public int NumJoueur;
    public GameObject DésBleu1;
    public GameObject DésBleu2;
    public GameObject DeB1;
    public GameObject Face1B1;
    public GameObject Face2B1;
    public GameObject Face3B1;
    public GameObject Face4B1;
    public GameObject Face5B1;
    public GameObject Face6B1;
    public GameObject DeB2;
    public GameObject Face1B2;
    public GameObject Face2B2;
    public GameObject Face3B2;
    public GameObject Face4B2;
    public GameObject Face5B2;
    public GameObject Face6B2;
    public GameObject DésNoir1;
    public GameObject DeN1;
    public GameObject Face1N1;
    public GameObject Face2N1;
    public GameObject Face3N1;
    public GameObject Face4N1;
    public GameObject Face5N1;
    public GameObject Face6N1;
    public GameObject DésNoir2;
    public GameObject DeN2;
    public GameObject Face1N2;
    public GameObject Face2N2;
    public GameObject Face3N2;
    public GameObject Face4N2;
    public GameObject Face5N2;
    public GameObject Face6N2;
    public GameObject DésOrange1;
    public GameObject DésOrange2;
    public GameObject DeOr1;
    public GameObject Face1O1;
    public GameObject Face2O1;
    public GameObject Face3O1;
    public GameObject Face4O1;
    public GameObject Face5O1;
    public GameObject Face6O1;
    public GameObject DeOr2;
    public GameObject Face1O2;
    public GameObject Face2O2;
    public GameObject Face3O2;
    public GameObject Face4O2;
    public GameObject Face5O2;
    public GameObject Face6O2;
    public GameObject DésVert1;
    public GameObject DésVert2;
    public GameObject DeV1;
    public GameObject Face1V1;
    public GameObject Face2V1;
    public GameObject Face3V1;
    public GameObject Face4V1;
    public GameObject Face5V1;
    public GameObject Face6V1;
    public GameObject DeV2;
    public GameObject Face1V2;
    public GameObject Face2V2;
    public GameObject Face3V2;
    public GameObject Face4V2;
    public GameObject Face5V2;
    public GameObject Face6V2;
    public List<Player> players;
    public int action;
    





    // Start is called before the first frame update
    void Start()
    {
        players = new List<Player>();
        tour = 0;
        TourJ = 4;
        NbJoueur = 2; //pour test le jeu est defini a 2 joueurs
        ChangeJoueur();
    }

    void Update()
    {
        if (action == 1)
        {
            Debug.Log("rejouer?");
        }
        
    }

    public void Turn()
    {
            action = 0;
            switch (TourJ)
            {
                case 1:
                    
                    tour = tour + 1;
                    DésBleu1.SetActive(true);
                    DésBleu2.SetActive(true);
                    DésNoir1.SetActive(true);
                    DésNoir2.SetActive(true);
                    DésOrange1.SetActive(true);
                    DésOrange2.SetActive(true);
                    DésVert1.SetActive(true);
                    DésVert2.SetActive(true);

                        DeB1.GetComponent<MeshRenderer>().enabled = true;
                        Face1B1.GetComponent<MeshRenderer>().enabled = true;
                        Face2B1.GetComponent<MeshRenderer>().enabled = true;
                        Face3B1.GetComponent<MeshRenderer>().enabled = true;
                        Face4B1.GetComponent<MeshRenderer>().enabled = true;
                        Face5B1.GetComponent<MeshRenderer>().enabled = true;
                        Face6B1.GetComponent<MeshRenderer>().enabled = true;

                        DeB2.GetComponent<MeshRenderer>().enabled = true;
                        Face1B2.GetComponent<MeshRenderer>().enabled = true;
                        Face2B2.GetComponent<MeshRenderer>().enabled = true;
                        Face3B2.GetComponent<MeshRenderer>().enabled = true;
                        Face4B2.GetComponent<MeshRenderer>().enabled = true;
                        Face5B2.GetComponent<MeshRenderer>().enabled = true;
                        Face6B2.GetComponent<MeshRenderer>().enabled = true;

                DeN1.GetComponent<MeshRenderer>().enabled = false;
                        Face1N1.GetComponent<MeshRenderer>().enabled = false;
                        Face2N1.GetComponent<MeshRenderer>().enabled = false;
                        Face3N1.GetComponent<MeshRenderer>().enabled = false;
                        Face4N1.GetComponent<MeshRenderer>().enabled = false;
                        Face5N1.GetComponent<MeshRenderer>().enabled = false;
                        Face6N1.GetComponent<MeshRenderer>().enabled = false;
                        
                    DeN2.GetComponent<MeshRenderer>().enabled = false;
                        Face1N2.GetComponent<MeshRenderer>().enabled = false;
                        Face2N2.GetComponent<MeshRenderer>().enabled = false;
                        Face3N2.GetComponent<MeshRenderer>().enabled = false;
                        Face4N2.GetComponent<MeshRenderer>().enabled = false;
                        Face5N2.GetComponent<MeshRenderer>().enabled = false;
                        Face6N2.GetComponent<MeshRenderer>().enabled = false;

                    DeOr1.GetComponent<MeshRenderer>().enabled = false;
                        Face1O1.GetComponent<MeshRenderer>().enabled = false;
                        Face2O1.GetComponent<MeshRenderer>().enabled = false;
                        Face3O1.GetComponent<MeshRenderer>().enabled = false;
                        Face4O1.GetComponent<MeshRenderer>().enabled = false;
                        Face5O1.GetComponent<MeshRenderer>().enabled = false;
                        Face6O1.GetComponent<MeshRenderer>().enabled = false;

                    DeOr2.GetComponent<MeshRenderer>().enabled = false;
                        Face1O2.GetComponent<MeshRenderer>().enabled = false;
                        Face2O2.GetComponent<MeshRenderer>().enabled = false;
                        Face3O2.GetComponent<MeshRenderer>().enabled = false;
                        Face4O2.GetComponent<MeshRenderer>().enabled = false;
                        Face5O2.GetComponent<MeshRenderer>().enabled = false;
                        Face6O2.GetComponent<MeshRenderer>().enabled = false;

                    DeV1.GetComponent<MeshRenderer>().enabled = false;
                        Face1V1.GetComponent<MeshRenderer>().enabled = false;
                        Face2V1.GetComponent<MeshRenderer>().enabled = false;
                        Face3V1.GetComponent<MeshRenderer>().enabled = false;
                        Face4V1.GetComponent<MeshRenderer>().enabled = false;
                        Face5V1.GetComponent<MeshRenderer>().enabled = false;
                        Face6V1.GetComponent<MeshRenderer>().enabled = false;

                DeV2.GetComponent<MeshRenderer>().enabled = false;
                        Face1V2.GetComponent<MeshRenderer>().enabled = false;
                        Face2V2.GetComponent<MeshRenderer>().enabled = false;
                        Face3V2.GetComponent<MeshRenderer>().enabled = false;
                        Face4V2.GetComponent<MeshRenderer>().enabled = false;
                        Face5V2.GetComponent<MeshRenderer>().enabled = false;
                        Face6V2.GetComponent<MeshRenderer>().enabled = false;

                break;

                case 2:

              
                DésBleu1.SetActive(true);
                DésBleu2.SetActive(true);
                DésNoir1.SetActive(true);
                DésNoir2.SetActive(true);
                DésOrange1.SetActive(true);
                DésOrange2.SetActive(true);
                DésVert1.SetActive(true);
                DésVert2.SetActive(true);


                DeB1.GetComponent<MeshRenderer>().enabled = false;
                Face1B1.GetComponent<MeshRenderer>().enabled = false;
                Face2B1.GetComponent<MeshRenderer>().enabled = false;
                Face3B1.GetComponent<MeshRenderer>().enabled = false;
                Face4B1.GetComponent<MeshRenderer>().enabled = false;
                Face5B1.GetComponent<MeshRenderer>().enabled = false;
                Face6B1.GetComponent<MeshRenderer>().enabled = false;

                DeB2.GetComponent<MeshRenderer>().enabled = false;
                Face1B2.GetComponent<MeshRenderer>().enabled = false;
                Face2B2.GetComponent<MeshRenderer>().enabled = false;
                Face3B2.GetComponent<MeshRenderer>().enabled = false;
                Face4B2.GetComponent<MeshRenderer>().enabled = false;
                Face5B2.GetComponent<MeshRenderer>().enabled = false;
                Face6B2.GetComponent<MeshRenderer>().enabled = false;

                DeN1.GetComponent<MeshRenderer>().enabled = true;
                Face1N1.GetComponent<MeshRenderer>().enabled = true;
                Face2N1.GetComponent<MeshRenderer>().enabled = true;
                Face3N1.GetComponent<MeshRenderer>().enabled = true;
                Face4N1.GetComponent<MeshRenderer>().enabled = true;
                Face5N1.GetComponent<MeshRenderer>().enabled = true;
                Face6N1.GetComponent<MeshRenderer>().enabled = true;

                DeN2.GetComponent<MeshRenderer>().enabled = true;
                Face1N2.GetComponent<MeshRenderer>().enabled = true;
                Face2N2.GetComponent<MeshRenderer>().enabled = true;
                Face3N2.GetComponent<MeshRenderer>().enabled = true;
                Face4N2.GetComponent<MeshRenderer>().enabled = true;
                Face5N2.GetComponent<MeshRenderer>().enabled = true;
                Face6N2.GetComponent<MeshRenderer>().enabled = true;

                DeOr1.GetComponent<MeshRenderer>().enabled = false;
                Face1O1.GetComponent<MeshRenderer>().enabled = false;
                Face2O1.GetComponent<MeshRenderer>().enabled = false;
                Face3O1.GetComponent<MeshRenderer>().enabled = false;
                Face4O1.GetComponent<MeshRenderer>().enabled = false;
                Face5O1.GetComponent<MeshRenderer>().enabled = false;
                Face6O1.GetComponent<MeshRenderer>().enabled = false;

                DeOr2.GetComponent<MeshRenderer>().enabled = false;
                Face1O2.GetComponent<MeshRenderer>().enabled = false;
                Face2O2.GetComponent<MeshRenderer>().enabled = false;
                Face3O2.GetComponent<MeshRenderer>().enabled = false;
                Face4O2.GetComponent<MeshRenderer>().enabled = false;
                Face5O2.GetComponent<MeshRenderer>().enabled = false;
                Face6O2.GetComponent<MeshRenderer>().enabled = false;

                DeV1.GetComponent<MeshRenderer>().enabled = false;
                Face1V1.GetComponent<MeshRenderer>().enabled = false;
                Face2V1.GetComponent<MeshRenderer>().enabled = false;
                Face3V1.GetComponent<MeshRenderer>().enabled = false;
                Face4V1.GetComponent<MeshRenderer>().enabled = false;
                Face5V1.GetComponent<MeshRenderer>().enabled = false;
                Face6V1.GetComponent<MeshRenderer>().enabled = false;

                DeV2.GetComponent<MeshRenderer>().enabled = false;
                Face1V2.GetComponent<MeshRenderer>().enabled = false;
                Face2V2.GetComponent<MeshRenderer>().enabled = false;
                Face3V2.GetComponent<MeshRenderer>().enabled = false;
                Face4V2.GetComponent<MeshRenderer>().enabled = false;
                Face5V2.GetComponent<MeshRenderer>().enabled = false;
                Face6V2.GetComponent<MeshRenderer>().enabled = false;


                break;

                case 3:

                DésBleu1.SetActive(true);
                DésBleu2.SetActive(true);
                DésNoir1.SetActive(true);
                DésNoir2.SetActive(true);
                DésOrange1.SetActive(true);
                DésOrange2.SetActive(true);
                DésVert1.SetActive(true);
                DésVert2.SetActive(true);


                DeB1.GetComponent<MeshRenderer>().enabled = false;
                Face1B1.GetComponent<MeshRenderer>().enabled = false;
                Face2B1.GetComponent<MeshRenderer>().enabled = false;
                Face3B1.GetComponent<MeshRenderer>().enabled = false;
                Face4B1.GetComponent<MeshRenderer>().enabled = false;
                Face5B1.GetComponent<MeshRenderer>().enabled = false;
                Face6B1.GetComponent<MeshRenderer>().enabled = false;

                DeB2.GetComponent<MeshRenderer>().enabled = false;
                Face1B2.GetComponent<MeshRenderer>().enabled = false;
                Face2B2.GetComponent<MeshRenderer>().enabled = false;
                Face3B2.GetComponent<MeshRenderer>().enabled = false;
                Face4B2.GetComponent<MeshRenderer>().enabled = false;
                Face5B2.GetComponent<MeshRenderer>().enabled = false;
                Face6B2.GetComponent<MeshRenderer>().enabled = false;

                DeN1.GetComponent<MeshRenderer>().enabled = false;
                Face1N1.GetComponent<MeshRenderer>().enabled = false;
                Face2N1.GetComponent<MeshRenderer>().enabled = false;
                Face3N1.GetComponent<MeshRenderer>().enabled = false;
                Face4N1.GetComponent<MeshRenderer>().enabled = false;
                Face5N1.GetComponent<MeshRenderer>().enabled = false;
                Face6N1.GetComponent<MeshRenderer>().enabled = false;

                DeN2.GetComponent<MeshRenderer>().enabled = false;
                Face1N2.GetComponent<MeshRenderer>().enabled = false;
                Face2N2.GetComponent<MeshRenderer>().enabled = false;
                Face3N2.GetComponent<MeshRenderer>().enabled = false;
                Face4N2.GetComponent<MeshRenderer>().enabled = false;
                Face5N2.GetComponent<MeshRenderer>().enabled = false;
                Face6N2.GetComponent<MeshRenderer>().enabled = false;

                DeOr1.GetComponent<MeshRenderer>().enabled = true;
                Face1O1.GetComponent<MeshRenderer>().enabled = true;
                Face2O1.GetComponent<MeshRenderer>().enabled = true;
                Face3O1.GetComponent<MeshRenderer>().enabled = true;
                Face4O1.GetComponent<MeshRenderer>().enabled = true;
                Face5O1.GetComponent<MeshRenderer>().enabled = true;
                Face6O1.GetComponent<MeshRenderer>().enabled = true;

                DeOr2.GetComponent<MeshRenderer>().enabled = true;
                Face1O2.GetComponent<MeshRenderer>().enabled = true;
                Face2O2.GetComponent<MeshRenderer>().enabled = true;
                Face3O2.GetComponent<MeshRenderer>().enabled = true;
                Face4O2.GetComponent<MeshRenderer>().enabled = true;
                Face5O2.GetComponent<MeshRenderer>().enabled = true;
                Face6O2.GetComponent<MeshRenderer>().enabled = true;

                DeV1.GetComponent<MeshRenderer>().enabled = false;
                Face1V1.GetComponent<MeshRenderer>().enabled = false;
                Face2V1.GetComponent<MeshRenderer>().enabled = false;
                Face3V1.GetComponent<MeshRenderer>().enabled = false;
                Face4V1.GetComponent<MeshRenderer>().enabled = false;
                Face5V1.GetComponent<MeshRenderer>().enabled = false;
                Face6V1.GetComponent<MeshRenderer>().enabled = false;

                DeV2.GetComponent<MeshRenderer>().enabled = false;
                Face1V2.GetComponent<MeshRenderer>().enabled = false;
                Face2V2.GetComponent<MeshRenderer>().enabled = false;
                Face3V2.GetComponent<MeshRenderer>().enabled = false;
                Face4V2.GetComponent<MeshRenderer>().enabled = false;
                Face5V2.GetComponent<MeshRenderer>().enabled = false;
                Face6V2.GetComponent<MeshRenderer>().enabled = false;
                break;

                case 4:

                DésBleu1.SetActive(true);
                DésBleu2.SetActive(true);
                DésNoir1.SetActive(true);
                DésNoir2.SetActive(true);
                DésOrange1.SetActive(true);
                DésOrange2.SetActive(true);
                DésVert1.SetActive(true);
                DésVert2.SetActive(true);


                DeB1.GetComponent<MeshRenderer>().enabled = false;
                Face1B1.GetComponent<MeshRenderer>().enabled = false;
                Face2B1.GetComponent<MeshRenderer>().enabled = false;
                Face3B1.GetComponent<MeshRenderer>().enabled = false;
                Face4B1.GetComponent<MeshRenderer>().enabled = false;
                Face5B1.GetComponent<MeshRenderer>().enabled = false;
                Face6B1.GetComponent<MeshRenderer>().enabled = false;

                DeB2.GetComponent<MeshRenderer>().enabled = false;
                Face1B2.GetComponent<MeshRenderer>().enabled = false;
                Face2B2.GetComponent<MeshRenderer>().enabled = false;
                Face3B2.GetComponent<MeshRenderer>().enabled = false;
                Face4B2.GetComponent<MeshRenderer>().enabled = false;
                Face5B2.GetComponent<MeshRenderer>().enabled = false;
                Face6B2.GetComponent<MeshRenderer>().enabled = false;

                DeN1.GetComponent<MeshRenderer>().enabled = false;
                Face1N1.GetComponent<MeshRenderer>().enabled = false;
                Face2N1.GetComponent<MeshRenderer>().enabled = false;
                Face3N1.GetComponent<MeshRenderer>().enabled = false;
                Face4N1.GetComponent<MeshRenderer>().enabled = false;
                Face5N1.GetComponent<MeshRenderer>().enabled = false;
                Face6N1.GetComponent<MeshRenderer>().enabled = false;

                DeN2.GetComponent<MeshRenderer>().enabled = false;
                Face1N2.GetComponent<MeshRenderer>().enabled = false;
                Face2N2.GetComponent<MeshRenderer>().enabled = false;
                Face3N2.GetComponent<MeshRenderer>().enabled = false;
                Face4N2.GetComponent<MeshRenderer>().enabled = false;
                Face5N2.GetComponent<MeshRenderer>().enabled = false;
                Face6N2.GetComponent<MeshRenderer>().enabled = false;

                DeOr1.GetComponent<MeshRenderer>().enabled = false;
                Face1O1.GetComponent<MeshRenderer>().enabled = false;
                Face2O1.GetComponent<MeshRenderer>().enabled = false;
                Face3O1.GetComponent<MeshRenderer>().enabled = false;
                Face4O1.GetComponent<MeshRenderer>().enabled = false;
                Face5O1.GetComponent<MeshRenderer>().enabled = false;
                Face6O1.GetComponent<MeshRenderer>().enabled = false;

                DeOr2.GetComponent<MeshRenderer>().enabled = false;
                Face1O2.GetComponent<MeshRenderer>().enabled = false;
                Face2O2.GetComponent<MeshRenderer>().enabled = false;
                Face3O2.GetComponent<MeshRenderer>().enabled = false;
                Face4O2.GetComponent<MeshRenderer>().enabled = false;
                Face5O2.GetComponent<MeshRenderer>().enabled = false;
                Face6O2.GetComponent<MeshRenderer>().enabled = false;

                DeV1.GetComponent<MeshRenderer>().enabled = true;
                Face1V1.GetComponent<MeshRenderer>().enabled = true;
                Face2V1.GetComponent<MeshRenderer>().enabled = true;
                Face3V1.GetComponent<MeshRenderer>().enabled = true;
                Face4V1.GetComponent<MeshRenderer>().enabled = true;
                Face5V1.GetComponent<MeshRenderer>().enabled = true;
                Face6V1.GetComponent<MeshRenderer>().enabled = true;

                DeV2.GetComponent<MeshRenderer>().enabled = true;
                Face1V2.GetComponent<MeshRenderer>().enabled = true;
                Face2V2.GetComponent<MeshRenderer>().enabled = true;
                Face3V2.GetComponent<MeshRenderer>().enabled = true;
                Face4V2.GetComponent<MeshRenderer>().enabled = true;
                Face5V2.GetComponent<MeshRenderer>().enabled = true;
                Face6V2.GetComponent<MeshRenderer>().enabled = true;
                break;
            }
        




    }

    

    public void ChangeJoueur()
    {
        if(TourJ == 1)
        {
            TourJ = 2;
            canvasJ1.SetActive(false);
            canvasJ2.SetActive(true);
            canvasJ3.SetActive(false);
            canvasJ4.SetActive(false);
            
            Turn();
        }
        else if(TourJ == 2)
        {
            TourJ = 3;
            canvasJ1.SetActive(false);
            canvasJ2.SetActive(false);
            canvasJ3.SetActive(true);
            canvasJ4.SetActive(false);

        }
        else if(TourJ == 3)
        {
            TourJ = 4;
            canvasJ1.SetActive(false);
            canvasJ2.SetActive(false);
            canvasJ3.SetActive(false);
            canvasJ4.SetActive(true);
        }
        else
        {
            TourJ = 1;
            canvasJ1.SetActive(true);
            canvasJ2.SetActive(false);
            canvasJ3.SetActive(false);
            canvasJ4.SetActive(false);
            Turn();
        }
    }
    public void ChangeCamera()
    {
        if (CameraMain.activeInHierarchy)
        {
            CameraMain.SetActive(false);
            CameraTop.SetActive(true);
        }
        else
        {
            CameraMain.SetActive(true);
            CameraTop.SetActive(false);
        }
    }

    public void Temple()
    {
        if (CameraMain.activeInHierarchy||CameraTop.activeInHierarchy)
        {
            TempleCamera.SetActive(true);
            CameraMain.SetActive(false);
            CameraTop.SetActive(false);
        }
        else
        {
            TempleCamera.SetActive(false);
            CameraMain.SetActive(false);
            CameraTop.SetActive(true);
        }
    }
}
