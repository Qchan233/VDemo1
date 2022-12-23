using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 _direction = new(1,0,0);
    private float _speed;
    [SerializeField] 

    public float Speed
    {
        set => _speed = value;
    }

    void FixedUpdate()
    {
        transform.position += _direction * _speed;
    }
}
