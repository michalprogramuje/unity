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
    void calculateMovement()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y < -4.15)
        {
            transform.position = new Vector3(Random.value*18.97f-9.45f, 6.2f, 0); //pole gry jest między -9.45 a +9.52 (x)
        }
    }
}
