using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TürSkript : MonoBehaviour
{
    [SerializeField] private int DoorIndex;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (transform.rotation.y < 1f)
        {
            transform.Rotate(0f, 90f, 0f);
        }
        else
        {
            transform.Rotate(0f, -90f, 0f);
        }
        DoorVariables.DoorsOpen[DoorIndex] = !DoorVariables.DoorsOpen[DoorIndex];
    }
}
