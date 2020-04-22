using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapScript : MonoBehaviour
{
    public Transform player; // Reference to Player
    void LateUpdate() // We use LateUpdate to ensure player has moved before updating Minimap (LateUpdate is called after Update and FixedUpdate).
    {
        Vector3 newPosition = player.position; // New position of our Minimap set to position of player.
        newPosition.y = transform.position.y; 
        transform.position = newPosition;
    }


}
