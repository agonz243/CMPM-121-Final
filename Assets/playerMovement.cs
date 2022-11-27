using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Create reference to character controller
    public CharacterController controller;
    public Transform cam;
    public Transform playerGFX;

    public float speed = 5f;

    public float turnSmoothing = 0.1f;
    float turnSmoothVel;

    

    void Start()
    {
        // Lock the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(inputH, 0f, inputV).normalized;

        if(direction.magnitude >= 0.1f) 
        {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVel, turnSmoothing);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);



            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
            
            // Rotate player model
            playerGFX.transform.Rotate(Vector3.right * speed/6);
        }
    }
}
