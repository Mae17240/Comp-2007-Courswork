using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class FpsController : MonoBehaviour
{
    //main player camera 
    public Camera mainPlayerCamera;

    //movement 
    public float walkingSpeed = 6f;
    public float runningSpeed = 12f;
    //jumping 
    public float jumpPower = 6f;
    public float gravityValue = 10f;
    //look speeds 
    public float lookSpeed = 2f;
    public float lookXlimit = 45f;
    //rotation 
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    public bool canMove = true;

    CharacterController characterController;
    
    
   
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked; //hiding the cursor / mouse 
        Cursor.visible = false;
    }


    void Update()
    {
        //fordward and right vectors 
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        //left shift to run

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;

        // calculate movement Direction
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);


        //Jumping 
        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }
        //gravity
        if (!characterController.isGrounded) 
        {
            moveDirection.y -= gravityValue * Time.deltaTime;
        }

        characterController.Move(moveDirection * Time.deltaTime);
        
        //looking around (rotation)
        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXlimit, lookXlimit);
            mainPlayerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed , 0);
        }

        
    }
}
