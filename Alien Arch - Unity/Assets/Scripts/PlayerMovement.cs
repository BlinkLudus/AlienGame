using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Speed settings in metres/second
    public float speed = 1;
    public float jumpSpeed = 1;
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;

    //Reference variable so we can use the Rigidbody
    private Rigidbody2D physicsBody = null;

    void Update()
    {
        Rigidbody2D ourRigidBody = GetComponent<Rigidbody2D>();

        //Find out from the rigidbody what our current horizontal and vertical speeds are
        float currentSpeedH = ourRigidBody.velocity.x;
        float currentSpeedV = ourRigidBody.velocity.y;

        //Get the animator component that will be setting our animation
        Animator ourAnimator = GetComponent<Animator>();

        //Tell our animator what the speeds are
        ourAnimator.SetFloat("speedH", currentSpeedH);
        ourAnimator.SetFloat("speedV", currentSpeedV);
    }



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
        newVelocity.x = -speed;

        //Update our physics component's velocity to be our newly changed value
        physicsBody.velocity = newVelocity;

    }

    public void MoveRight()
    {
        //Make a variable to hold our velocity and get 
        //the current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;

        //Set our velocity to move in the negative x (left) direction
        newVelocity.x = speed;

        //Update our physics component's velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            //Make a variable to hold our velocity and get 
            //the current velocity from the physics component
            Vector2 newVelocity = physicsBody.velocity;

            //Set our velocity to move in the y direction
            newVelocity.y = jumpSpeed;

            //Update our physics component's velocity to be our newly changed value
            physicsBody.velocity = newVelocity;
        }
      
    }
}
