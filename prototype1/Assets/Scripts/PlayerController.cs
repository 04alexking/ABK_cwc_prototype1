using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalMovement;
    private float forwardMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get player input
        horizontalMovement = Input.GetAxis("Horizontal");
        forwardMovement = Input.GetAxis("Vertical");

        // move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardMovement);
        transform.Rotate(Vector3.up, turnSpeed * horizontalMovement * Time.deltaTime);
    }
}
