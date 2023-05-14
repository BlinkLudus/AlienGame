using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    // Update is called once per frame
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
}
