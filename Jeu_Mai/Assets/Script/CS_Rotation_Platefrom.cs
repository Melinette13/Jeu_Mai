using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Rotation_Platefrom : MonoBehaviour
{
    public GameObject PlateformToSpin;
    public float degrees = 20;
   

    public void PlateformRoataion()
    {
      
            PlateformToSpin.transform.Rotate(new Vector3(0, 0, degrees) * Time.deltaTime);  
    }
    public void StopPlateformRoataion()
    {

        PlateformToSpin.transform.Rotate(new Vector3(0, 0, 0) * Time.deltaTime);
    }
}
