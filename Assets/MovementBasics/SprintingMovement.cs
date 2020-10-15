using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintingMovement : MonoBehaviour
{
    // you can initialize variables at their declaration
    public float walkSpeed = 4f;
    public float sprintSpeed = 8f;

    private float realSpeed;

    void Update()
    {
        // you can use the ternary operator in this case
        realSpeed = Input.GetKey(KeyCode.LeftShift) ? walkSpeed : sprintSpeed;
    }

    // physics (which movement is) should go into FixedUpdate
    void FixedUpdate()
    {
        transform.Translate(realSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, realSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }

}
