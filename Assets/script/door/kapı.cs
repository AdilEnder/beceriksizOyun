using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class kap� : MonoBehaviour
{

    public float distance;
    public GameObject etouch;// deg�skenler
    public GameObject hinge;
    public GameObject tr�gger;


   



    void Update()
    {
     distance = playerRay.thedistance; // deg�skene baglan scr�pt ad�
    }

    void OnMouseOver() // mouse ustundeyse
    {

        if (distance <= 2)
        {
           
            etouch.SetActive(true);
            

        }
        else
        {
            
            etouch.SetActive(false);
            

        }
        if (Input.GetKey(KeyCode.E)) 
        {

            if (distance <= 2)
            {

                this.gameObject.GetComponent<BoxCollider>().enabled = false; // objen�n col�der�n� yok eder
                etouch.SetActive(false);
                hinge.GetComponent<Animation>().Play("kap�"); // an�masyon bok g�b� 
                


            }


        }


    }

    void OnMouseExit()
    {   
        etouch.SetActive(false);
    }


}
