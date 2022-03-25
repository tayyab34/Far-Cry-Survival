using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private Image health_Stats, stamina_Stats;

    public void display_HealthStats(float healthValue)
    {
        healthValue /= 100f;
        health_Stats.fillAmount = healthValue;
    }

    public void display_StaminaStats(float staminaValue)
    {
        staminaValue /= 100f;
        stamina_Stats.fillAmount = staminaValue;
    }
}
