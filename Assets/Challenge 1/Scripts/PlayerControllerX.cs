using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float _verticalInput;
    private readonly float _speed = 15f;
    private readonly float _rotationSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate( Vector3.right, _verticalInput * _rotationSpeed * Time.deltaTime);
    }
}
