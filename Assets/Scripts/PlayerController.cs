using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float Speed = 18f;
    private const float TurnSpeed = 28f;
    private float _horizontalInput;
    private float _forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        
        // Note: When multiplying by Time.deltaTime, we effectively
        // convert the transformation from once per frame to once per second
        
        // Move the vehicle forward based on vertical input
        transform.Translate( Speed * _forwardInput * Time.deltaTime * Vector3.forward);
        
        // Rotate the vehicle around the vertical axis based on horizontal input
        transform.Rotate(Vector3.up, TurnSpeed * _horizontalInput * Time.deltaTime);
    }
}
