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
    
    [SerializeField] private float _coolDown = 0.6f;
    [SerializeField] private float _weaponRange = 10;
    [SerializeField] private bool fireEnabled = true;
    [SerializeField] private GameObject bullet;
    private const int NUMFIND = 3;
    private Vector3 _direction;
    
    private void Start()
    {
        TimersManager.SetLoopableTimer(this, _coolDown, FireBullet);
    }

    public void FireBullet()
    {
        _direction = AimAtEnemy();
        if (_direction == Vector3.zero)
        {
            _direction = new Vector3(1, 0, 0);
        }

        Instantiate(bullet, transform.position, Quaternion.LookRotation(Vector3.forward, _direction));
        bullet
    }
    
    private Vector3 AimAtEnemy()
    {
        var results = new Collider2D[NUMFIND];
        Physics2D.OverlapCircleNonAlloc(transform.position, _weaponRange, results);

        foreach (var result in results)
        {
            if (result!= null && result.CompareTag("Enemy"))
            {
                return (result.transform.position - transform.position).normalized;
            }
        }
        return new Vector3(1,0,0);
    }
}
