using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class kapý : MonoBehaviour
{

    public GameObject door;
    public GameObject TriggerDoor;
    public float distance;
    playerRay ray;
    public GameObject E;

    void Start()
    {
        
    }

    
    void Update()
    {
        ray = FindObjectOfType<playerRay>();

        distance = ray.totarget;


        if (distance < 2)
        {
            E.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {

                TriggerDoor.gameObject.GetComponent<MeshCollider>().enabled = false;
                door.gameObject.GetComponent<Animation>().Play("AnýmasyonAdý");
                
            }     
            else
            {
                
                    E.SetActive(false);

            }

            


        }

        

    }
}
