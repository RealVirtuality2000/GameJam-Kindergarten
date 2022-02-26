using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDelete : MonoBehaviour
{
    [SerializeField] private int StoneIndex;

    private void Start()
    {
        if(DoorVariables.DoorsOpen[StoneIndex] == true)
        {
            gameObject.SetActive(false);
        }
    }
}
