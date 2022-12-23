using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
using Plane = System.Numerics.Plane;
using Vector2 = UnityEngine.Vector2;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 _inputDirection;
    private const float threshold = 0.05f;
    
    public void Move(InputAction.CallbackContext context)
    {
        _inputDirection =  context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        var position = (Vector2) transform.position;
        var targetPosition = position + _inputDirection;
        if ((position - targetPosition).magnitude<threshold) return;
        rb.DOMove(targetPosition, speed).SetSpeedBased();
    }
}
