﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] // pole widać w unity (Inspector, mimo ze jest prywatne
    private float _speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab;
    [SerializeField]
    private float _fireRate = 0.5f;
    private float _nextFire = -0.5f;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    void Update()
    {
        calculateMovement();
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire)
            laserSpawn();
                }
    void laserSpawn()
    {
            _nextFire = Time.time + _fireRate;
            Instantiate(_laserPrefab, transform.position + new Vector3(0,0.7f,0), Quaternion.identity);

    }
    void calculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0));

        if (transform.position.x >= 9.23)
        {
            transform.position = new Vector3(-9.22f, transform.position.y, 0);
        }
        else if (transform.position.x <= -9.23)
        {
            transform.position = new Vector3(9.22f, transform.position.y, 0);
        }
    }
}
