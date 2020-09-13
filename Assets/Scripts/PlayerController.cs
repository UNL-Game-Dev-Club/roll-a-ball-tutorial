using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] [Range(0.0f, 100.0f)] private float speed = 10.0f;
    
    private Rigidbody rigidbody;
    private Vector3 movement;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(movement * speed);       
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        
        movement = new Vector3(movementVector.x, 0.0f, movementVector.y);
    }
}
