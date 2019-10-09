﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8f;
    void Start()
    {

    }

    void Update()
    {
        calculateMovement();
    }
    void calculateMovement()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        if (transform.position.y >= 7.1f)
        {
            Destroy(this.gameObject);
        }
    }
}
