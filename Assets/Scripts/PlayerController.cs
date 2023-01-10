using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float speed = 15.0f;
    private float rotationSpeed = 20.0f;
    private float verticalInput;
    private float horizontalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Moves forward based on horizontal input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);
        // Tilt up/down based on vertical input
        transform.Rotate(Vector3.left, rotationSpeed * verticalInput * Time.deltaTime);
    }
}
