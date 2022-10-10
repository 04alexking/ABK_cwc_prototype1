using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float startZ = 0.0f;
    public float endZ = 50.0f;
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

        float newX = Mathf.Clamp(transform.position.x, -9.0f, 9.0f);
        float newZ = transform.position.z;
        if (transform.position.z > endZ) {
            newZ -= (endZ-startZ);
        }
        transform.position = new Vector3(newX, transform.position.y, newZ);

    }
}
