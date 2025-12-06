using System;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float MoveSpeed = 1.0f;
    public Vector2 MoveDirection = Vector2.down;
    public float RotationSpeed = 90.0f;

    private void Update()
    {
        // move
        transform.Translate(MoveDirection * (MoveSpeed * Time.deltaTime), Space.World);
    
        // spin
        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime, Space.Self);
    }
}
