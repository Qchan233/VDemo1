using System;
using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class WeaponFire : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private float _coolDown;

    [SerializeField] private bool fireEnabled = true;
    [SerializeField] private GameObject bullet;
    [SerializeField] private UnityEvent FireEvent;

    private Vector3 _direction;
    
    private void Start()
    {
        TimersManager.SetLoopableTimer(this, _coolDown, FireBullet);
    }

    public void FireBullet()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
        FireEvent.Invoke();
    }
}
