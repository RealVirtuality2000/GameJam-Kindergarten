using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarSkript : MonoBehaviour
{
    public Slider slider;

    public void SetHealth(float health)
    {
        slider.value = health;
    }

    public void SetMaxHealth(float maxhealth)
    {
        slider.maxValue = maxhealth;
        slider.value = maxhealth;
    }
}
