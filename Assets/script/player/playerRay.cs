using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRay : MonoBehaviour
{
    public float totarget;
    public static float thedistance;

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
