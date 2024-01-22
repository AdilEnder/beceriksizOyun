using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class kapý : MonoBehaviour
{

    public float distance;
    public GameObject etouch;// degýskenler
    public GameObject hinge;
    public GameObject trýgger;


   



    void Update()
    {
     distance = playerRay.thedistance; // degýskene baglan scrýpt adý
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

                this.gameObject.GetComponent<BoxCollider>().enabled = false; // objenýn colýderýný yok eder
                etouch.SetActive(false);
                hinge.GetComponent<Animation>().Play("kapý"); // anýmasyon bok gýbý 
                


            }


        }


    }

    void OnMouseExit()
    {   
        etouch.SetActive(false);
    }


}
