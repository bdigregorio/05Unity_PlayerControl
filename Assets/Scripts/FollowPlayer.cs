using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public GameObject player;
    [SerializeField] private Vector3 cameraOffset;

    private void LateUpdate() {
        // Pin the camera to the player position + offset
        transform.position = player.transform.position + cameraOffset;
    }
}
