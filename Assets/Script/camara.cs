using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Camera camara1;
    public Camera camara2;
    public Camera camara3;
    public Camera camara4;
    public Camera camara5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetButtonDown("Cam1"))
        {
            camara1.enabled = true;
            camara2.enabled = false;
            camara3.enabled = false;
            camara4.enabled = false;
            camara5.enabled = false;
        }
       

        if (Input.GetButtonDown("Cam2"))
        {
            camara1.enabled = false;
            camara2.enabled = true;
            camara3.enabled = false;
            camara4.enabled = false;
            camara5.enabled = false;
        }
        if (Input.GetButtonDown("Cam3"))
        {
            camara1.enabled = false;
            camara2.enabled = false;
            camara3.enabled = true;
            camara4.enabled = false;
            camara5.enabled = false;
        }
        if (Input.GetButtonDown("Cam4"))
        {
            camara1.enabled = false;
            camara2.enabled = false;
            camara3.enabled = false;
            camara4.enabled = true;
            camara5.enabled = false;
        }
        if (Input.GetButtonDown("Cam5"))
        {
            camara1.enabled = false;
            camara2.enabled = false;
            camara3.enabled = false;
            camara4.enabled = false;
            camara5.enabled = true;
        }

    }
}
