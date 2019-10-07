using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] // pole widać w unity (Inspector, mimo ze jest prywatne
    private float _speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    void Update()
    {
        calculateMovement();
        laserSpawn();
                }
    void laserSpawn()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_laserPrefab, transform.position + new Vector3(0,0.7f,0), Quaternion.identity);
        }

    }
    void calculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

       /* if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y <= -3.8)
        {
            transform.position = new Vector3(transform.position.x, -3.8f, 0);
        } TO JEST TO SAMO CO: */
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0));   // TO XD

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
