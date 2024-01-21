using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuController : MonoBehaviour
{
    private CharacterController control;

    Vector3 velo;
    public bool yerdemi;

    public LayerMask maske;
    public Transform yer;
    public float cekimhizi = 0.3f;

    public float hiz;
    public float ziplamaYukseklik;
    public float yercekimi;

    
    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    void Update()
    {
        float saga = Input.GetAxis("Horizontal");
        float ileri = Input.GetAxis("Vertical");

        #region Haraket
        Vector3 yurume = transform.right * saga + transform.forward * ileri;
        control.Move(yurume * hiz * Time.deltaTime);
        #endregion


        #region Zýplama
        
        if (Input.GetKeyDown(KeyCode.Space) && yerdemi)
        {
            print("zýpla");
            velo.y = velo.y + Mathf.Sqrt(ziplamaYukseklik * -3.0f * yercekimi);
        }

        #endregion

        yerdemi = Physics.CheckSphere(yer.position, cekimhizi, maske);
        if(yerdemi && velo.y<0)
        {
            velo.y = 0f;
        }
        velo.y += yercekimi * Time.deltaTime;
        control.Move(velo * Time.deltaTime);
    }


}
