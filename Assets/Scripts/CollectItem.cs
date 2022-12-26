using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CollectItem : MonoBehaviour
{
    [SerializeField] private int _coinAmount;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
        AddCoin();
    }

    void AddCoin()
    {
        MoneyManager.Money += _coinAmount;
    }
}
