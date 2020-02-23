using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform PlayerTransform;
    private Vector3 CameraOffSet;

    public float SmoothFactor = 0.125f;

    // Start is called before the first frame update
    void Start()
    {
        CameraOffSet = transform.position - PlayerTransform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = PlayerTransform.position + CameraOffSet;
        Vector3 SmoothPos = Vector3.Lerp(transform.position, newPos, SmoothFactor);
        transform.position = SmoothPos;
    }
}
