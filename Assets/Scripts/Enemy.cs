using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;
    void Start()
    {
        
    }
    void Update()
    {
        calculateMovement();
    }
    void OnTriggerEnter(Collider other)
    {
        spawnAtRandom();
    }
    void calculateMovement()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y < -4.15)
        {
            spawnAtRandom();
        }
    }
    void spawnAtRandom()
    {
        float randomNumber = Random.Range(-9.45f, 9.52f);
        transform.position = new Vector3(randomNumber, 6.2f, 0);
    }
}
