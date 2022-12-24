using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 _direction;
    [SerializeField] private float _speed = 10;
    private const int NUMFIND = 3;
    [SerializeField] private float _bulletRange = 10;
    public float Speed
    {
        set => _speed = value;
    }

    public Vector3 Direction
    {
        set => _direction = value;
    }

    private void Start()
    {
        _direction = AimAtEnemy();
        transform.rotation = Quaternion.LookRotation(Vector3.forward, _direction); 
    }

    void FixedUpdate()
    {
        transform.position += _direction * _speed;
    }
    private Vector3 AimAtEnemy()
    {
        var results = new Collider2D[NUMFIND];
        Physics2D.OverlapCircleNonAlloc(transform.position, _bulletRange, results);

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
