using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    //Reference variable so we can use the Rigidbody
    private Rigidbody2D physicsBody = null;

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        //Make a variable to hold our velocity and get 
        //the current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;

        //Set our velocity to move in the negative x (left) direction
        newVelocity.x = -1;

        //Update our physics component's velocity to be our newly changed value
        physicsBody.velocity = newVelocity;

    }
}
