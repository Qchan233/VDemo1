using System;
using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    private bool _canAttack = true;
    [SerializeField] private string targetTag;
    [SerializeField] private UnityEvent attackEvent;

    public void CanAttack()
    {
        _canAttack = true;
    }
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
        if (!_canAttack) return;
        
        if (col.CompareTag(targetTag))
        {
            var damageable = col.GetComponent<Damageable>();
            damageable.TakeDamage(1);
            _canAttack = false;
            TimersManager.SetTimer(this, 1, CanAttack);
            attackEvent.Invoke();
        }
    }
}