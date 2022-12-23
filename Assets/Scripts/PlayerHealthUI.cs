using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider healthBar;
    [FormerlySerializedAs("status")] [SerializeField] private Health health;
    void Awake()
    {
        healthBar.maxValue = health.HealthValue;
        healthBar.value = health.HealthValue;
    }

    public void UpdateUI()
    {
        healthBar.value = health.HealthValue;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
