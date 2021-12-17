using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacementCam : MonoBehaviour
{
    public int velocity;
    public Vector3 Maxzoom;
    public Vector3 Minzoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * velocity);

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * velocity);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(Vector3.right * Time.deltaTime * velocity);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(Vector3.left * Time.deltaTime * velocity);
            }

            if (Input.GetKey(KeyCode.KeypadPlus))
            {
                this.transform.Translate(Vector3.down * Time.deltaTime * velocity);
            }

            if (Input.GetKey(KeyCode.KeypadMinus))
            {
                this.transform.Translate(Vector3.up * Time.deltaTime * velocity);
            }
        
    }
}
