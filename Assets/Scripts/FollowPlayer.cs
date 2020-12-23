using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private readonly Vector3 _cameraOffset = new Vector3(0, 7, -10);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Pin the camera to the player position + offset
        transform.position = player.transform.position + _cameraOffset;
    }
}
