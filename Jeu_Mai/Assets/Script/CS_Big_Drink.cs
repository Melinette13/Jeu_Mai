using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Big_Drink : MonoBehaviour
{

    public List<GameObject> PlaterformDisapear = new List<GameObject>();

    //test
    void Start()
    {
        for (int i = 0; i < PlaterformDisapear.Count; i++)
        {
            PlaterformDisapear[i].SetActive(false);
        }
    }
    void OnTriggerEnter()
    {
        for (int i = 0; i < PlaterformDisapear.Count; i++)
        {
            PlaterformDisapear[i].SetActive(true);
        }
    }
}
