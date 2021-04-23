﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour
{

    public float accelDown = 1f;
    public Animator animator;
    public CharacterController charController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        charController.Move(Vector3.down * accelDown * Time.deltaTime);
        animator.SetFloat("vertical", 0);
        animator.SetFloat("horizontal", 0);
        if (Input.GetKey(KeyCode.I))
        {
            animator.SetFloat("vertical", 1);
        }else if (Input.GetKey(KeyCode.M))
        {
            animator.SetFloat("vertical", -1);
        }

        if (Input.GetKey(KeyCode.J))
        {
            animator.SetFloat("horizontal", -1);
        }else if (Input.GetKey(KeyCode.L))
        {
            animator.SetFloat("horizontal", 1);
        }
        
    }
}
