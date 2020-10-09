using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintingMovement : MonoBehaviour
{
    public float speed;
    public float sprintSpeed;
    // Start is called before the first frame update
    void Start()
    {
            speed = 5.0f;
            sprintSpeed = 8.0f;
    }

    // Update is called once per frame


       

        void update()
        {


         transform.Translate(walkSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, walkSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
            //sprinting if statment using leftshift as keybind


            if (Input.GetKey(KeyCode.LeftShift))

            {
                speed = sprintSpeed;
            }
            else

            {
                speed = speed;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed = 5.0f;
            }
        }
   
}
