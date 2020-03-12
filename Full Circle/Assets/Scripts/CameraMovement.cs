using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform PlayerTransform; // Gets Player Transform
    private Vector3 CameraOffSet; // How far the camera is away from the player

    public float SmoothFactor = 0.125f; // Smoothness factor, oolala

    // Start is called before the first frame update
    void Start()
    {
        CameraOffSet = transform.position - PlayerTransform.position; // Gets position of camera and checks it against the player's position
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + CameraOffSet; // If player moves, updates new position variable
        Vector3 SmoothPos = Vector3.Lerp(transform.position, newPos, SmoothFactor); // Smooths camera transition
        transform.position = SmoothPos; // Moves Camera
    }
}
