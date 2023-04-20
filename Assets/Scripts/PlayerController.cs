using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float speed = 5;
    Rigidbody playerRb;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(transform.forward * speed * verticalInput);
        playerRb.AddTorque(Vector3.up * horizontalInput/4);

        if (transform.position.z > 25)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 25);
            playerRb.velocity = Vector3.zero;
        }
        if (transform.position.x > 25)
        {
            transform.position = new Vector3(25, transform.position.y, transform.position.z);
            playerRb.velocity = Vector3.zero;
        }
        if (transform.position.z < -25)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -25);
            playerRb.velocity = Vector3.zero;
        }
        if (transform.position.x < -25)
        {
            transform.position = new Vector3(-25, transform.position.y, transform.position.z);
            playerRb.velocity = Vector3.zero;
        }
    }
}
