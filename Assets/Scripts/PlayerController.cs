using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // multiplying * Time.deltaTime converts the translation
        // to per second from per frame
        transform.Translate( speed * Time.deltaTime * Vector3.forward);
    }
}
