using System;
using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMissleAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private const string targetTag = "Enemy";
    [SerializeField] private UnityEvent attackEvent;
    [SerializeField] private int damage;
    private void OnTriggerStay2D(Collider2D col)
    {
        DealDamage(col);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
       DealDamage(col); 
    }

    private void DealDamage(Collider2D col)
    {
        if (col.CompareTag(targetTag))
        {
            var enemyHealth  = col.GetComponent<EnemyHealth>();
            enemyHealth.DecreaseHealth(damage);
            attackEvent.Invoke();
        }
    }
}