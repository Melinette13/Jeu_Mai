using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Small_Drink_Métal : MonoBehaviour
{
    public GameObject Glass_Small_Drink; 
    public CS_Small_Drink small_Drink; 

    void Strat()
    {
        small_Drink = Glass_Small_Drink.GetComponent<CS_Small_Drink>();
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("what");

        if (collision.tag == "Player")
        {
            small_Drink.Drinking = false;
        }


    }
}
