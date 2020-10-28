using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class activation : MonoBehaviour
{
    public bool grounded;

    public GameObject button;
    public Rigidbody player;
    public float thrust = 1f;

    public Vector3 grapple;
    void Start()
    {
        grapple = new Vector3(1.0f, 1.0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (grounded = false)
        {
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
           player.AddForce(transform.up * thrust);
           player.AddForce(-transform.forward * thrust);
           grounded = false;
            //player.AddForce(grapple * thrust, ForceMode.Impulse);
            button.SetActive(false);
        }

        throw new NotImplementedException();
        
        Debug.Log("Mouse has enterd object ");
    }

    void OnCollisionStay(Collision other)
    {
        grounded = true;
        Debug.Log("on floor");
        throw new NotImplementedException();
    }
}
