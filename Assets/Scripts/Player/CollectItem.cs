using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider col)
    {
        Debug.Log("Coin");
        Destroy(col.gameObject);
    }
}
