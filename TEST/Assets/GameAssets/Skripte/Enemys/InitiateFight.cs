using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateFight : MonoBehaviour
{
    public GameObject enemys;
    private void OnTriggerEnter(Collider other)
    {
        enemys.SetActive(true);
    }
}
