﻿/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{


    [SerializeField]
    float speed;

    private Rigidbody _myrb;
    private Vector3 _inputDirection;
    // Use this for initialization
    void Start()
    {
        _myrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        _inputDirection = new Vector3(x, 0f, z);

        if (_inputDirection != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_inputDirection.normalized), 0.2f);

    }
}*/