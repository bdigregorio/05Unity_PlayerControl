using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private float _rotation = 1080f;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller
        transform.Rotate(Vector3.forward, _rotation * Time.deltaTime);
    }
}
