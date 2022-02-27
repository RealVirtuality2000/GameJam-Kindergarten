using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rucksack : MonoBehaviour
{
    public GameObject RucksackUI;
    private bool RucksackBool = true;
    private Outline Skript;

    private void Start()
    {
        Skript = gameObject.GetComponent<Outline>();
    }

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

    private void OnMouseOver()
    {
        Skript.enabled = true;
    }

    private void OnMouseExit()
    {
        Skript.enabled = false;
    }
}
