using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRay : MonoBehaviour
{
    
    public static float thedistance;
    public float totarget;
    
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection (Vector3.forward), out hit))
        {
          
            totarget = hit.distance;
            thedistance = totarget;


        }


    }
}
