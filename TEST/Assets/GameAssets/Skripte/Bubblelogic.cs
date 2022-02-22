using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubblelogic : MonoBehaviour
{
    public float speed = 5;

    private void FixedUpdate()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            PlayerActions.lifepoints -= 10;
            Debug.Log(PlayerActions.lifepoints);
        }
        Destroy(gameObject);
        
    }

}
