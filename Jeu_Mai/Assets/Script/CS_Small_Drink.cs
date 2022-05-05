using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Small_Drink : MonoBehaviour
{
    
    public List<GameObject> PlateformToSpin = new List<GameObject>();
    
    public CS_Rotation_Platefrom rotation_Platefrom;
    public CS_Rotation_Platefrom Onerotation_Platefrom;
    public CS_Rotation_Platefrom Tworotation_Platefrom;

    public bool Drinking; 




    void Start()
    {
        for (int i = 0; i < PlateformToSpin.Count; i++)
        {
            rotation_Platefrom = PlateformToSpin[i].GetComponent<CS_Rotation_Platefrom>();
            Drinking = false;
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("what");

        if (collision.tag=="Player") 
        {
            Drinking = true;
        }     

       
    }
    void Update()
    {
        if (Drinking == true)
        {
            rotation_Platefrom.PlateformRoataion();
            Onerotation_Platefrom.PlateformRoataion();
            Tworotation_Platefrom.PlateformRoataion();
            Debug.Log("ca tourne ");
            
        }
    }
}
