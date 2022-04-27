using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Rotation_Cube : MonoBehaviour
{
    public GameObject PlateformToSpin;
    public CS_Rotation_Platefrom rotation_Platefrom; 
    

   
    void Start()
    {
       rotation_Platefrom = PlateformToSpin.GetComponent<CS_Rotation_Platefrom>();
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("what");

        if (collision.tag=="Player") 
        {
            Debug.Log("what2");
            rotation_Platefrom.PlateformRoataion();
        }       
    }
}
