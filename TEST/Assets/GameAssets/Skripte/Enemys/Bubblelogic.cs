using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubblelogic : MonoBehaviour
{
    public float speed = 5;
    private HealthbarSkript healthbar;

    private void FixedUpdate()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
        healthbar = GameObject.Find("HealthbarPlayer").GetComponent<HealthbarSkript>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("SoapBubble");
            PlayerStats.lifepoints -= 10;            
            healthbar.SetHealth(PlayerStats.lifepoints);
            Debug.Log("Your Current Health is: ");
            Debug.Log(PlayerStats.lifepoints);
        }
        Destroy(gameObject);
        
    }

}
