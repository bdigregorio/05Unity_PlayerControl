using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float Speed = 18f;
    [SerializeField] private const float turnSpeed = 28f;
    private float horizontalInput;
    private float forwardInput;
    
    private void FixedUpdate() {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Note: When multiplying by Time.deltaTime, we effectively
        // convert the transformation from once per frame to once per second
        
        // Move the vehicle forward based on vertical input
        transform.Translate( Speed * forwardInput * Time.deltaTime * Vector3.forward);
        
        // Rotate the vehicle around the vertical axis based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
