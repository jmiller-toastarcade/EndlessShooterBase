using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float MoveSpeed = 5.0f;
    
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = transform.up * MoveSpeed;
    }
}
