using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 _direction;
    [SerializeField] private float _speed = 10;
    
    public float Speed
    {
        set => _speed = value;
    }

    public Vector3 Direction
    {
        set => _direction = value;
    }

    void FixedUpdate()
    {
        transform.position += _direction * _speed;
    }
}
