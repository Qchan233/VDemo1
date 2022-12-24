using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private UnityEvent<int> DiedEvent;
    [SerializeField] private int enemyEXP; 
    public void CheckDeath(int health)
    {
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);
        DiedEvent.Invoke(enemyEXP);
    }  
}
