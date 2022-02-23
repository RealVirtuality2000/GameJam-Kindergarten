using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    private float Health = 500f;
    public bool isInvulnerable = false;
    public HealthbarSkript healthbar;

    private void Start()
    {
        healthbar.SetMaxHealth(Health);
    }
    public void TakeDamage(float Damage)
    {
        if (isInvulnerable) return;

        Health -= Damage;
        healthbar.SetHealth(Health);

        if(Health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
