using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class kap� : MonoBehaviour
{

    public GameObject door;
    public GameObject TriggerDoor;
    public float distance;
    public Animation anim;
    public GameObject E;

    void Start()
    {
        anim = GetComponent<Animation>();
    }

    
    void Update()
    {

        distance = playerRay.thedistance;
        


        

        

    }

    void OnMouseOver()
    {

        if (distance < 2)
        {
            E.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {

                TriggerDoor.GetComponent<BoxCollider>().enabled = false;
                anim.gameObject.GetComponent<Animation>().Play("s�kcemAnan�");


            }

        }
        else
        {

            E.SetActive(false);

        }

    }
    void OnMouseExit()
    {
        
        if (distance < 2)
        {

            E.SetActive(false);

        }

    }
}
