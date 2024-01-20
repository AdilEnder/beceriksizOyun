using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseKontrol : MonoBehaviour
{

    public float hassasiyet;
    public Transform govde;//karakter g�vdesi

    float Rotasyon = 0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        float xR = Input.GetAxisRaw("Mouse X") * hassasiyet * Time.deltaTime;
        float yR = Input.GetAxisRaw("Mouse Y") * hassasiyet * Time.deltaTime;

        Rotasyon = Rotasyon - yR;
        transform.localRotation = Quaternion.Euler(Rotasyon, 0f, 0f);

        govde.Rotate(Vector3.up * xR);
    }
}
