using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
}