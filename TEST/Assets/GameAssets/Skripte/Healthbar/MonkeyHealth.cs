using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyHealth : MonoBehaviour
{
    private float Health = 75;
    public HealthbarSkript healthbar;

    private void Start()
    {
        healthbar.SetMaxHealth(Health);
    }

    public void TakeDamage(float Damage)
    {
        
        Health -= Damage;
        healthbar.SetHealth(Health);

        if (Health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
