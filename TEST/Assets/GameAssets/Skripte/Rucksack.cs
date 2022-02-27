using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rucksack : MonoBehaviour
{
    public GameObject RucksackUI;
    public bool RucksackBool = true;

    private void OnMouseDown()
    {
        if(RucksackBool == true)
        {
            RucksackUI.SetActive(true);
            PlayerStats.candy++;
            RucksackBool = false;
        }
        else { RucksackUI.SetActive(false); }
        Debug.Log("Rucksack jey!");
    }
}
