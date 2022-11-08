using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;

    public float speed = 12f;

    private float gravity = -9.81f;

    public Transform groundCheck;

    public float sphereRadius = 0.3f;

    public LayerMask groundMask;

    bool isGrounded;

    Vector3 velocity;

    public float jumpHeigh = 3;


    
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position,sphereRadius,groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; 
        }


        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeigh * -2 * gravity);
        }


        characterController.Move(move*speed*Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity*Time.deltaTime);


    }
}