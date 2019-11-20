using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "obstacle")
        {
            movement.enabled = false;
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.CompleteLevel();
        }        
    }

    

}
