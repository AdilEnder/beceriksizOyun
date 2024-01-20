using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseKontrol : MonoBehaviour
{

    public float hassasiyet = 100f;
    public Transform govde;//karakter gövdesi

    float Rotasyon = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        float xR = Input.GetAxisRaw("Mouse X") * hassasiyet * Time.deltaTime;
        float yR = Input.GetAxisRaw("Mouse Y") * hassasiyet * Time.deltaTime;

        Rotasyon = Mathf.Clamp(Rotasyon - yR, -90f, 90f);
        transform.localRotation = Quaternion.Euler(Rotasyon, 0f, 0f);

        govde.Rotate(Vector3.up * xR);
    }
}
