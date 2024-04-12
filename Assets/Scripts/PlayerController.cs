using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    private float speed = 20.0f; 
    private float turnSpeed = 70.0f;  
    private float horizontalInput; 
    private float forwardInput;
    public float xRange = 15; 
    public float zRange = 15;
    public GameObject projectilePrefab; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward based on vertical input 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (transform.position.x < -xRange)
{
transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
}
if (transform.position.x > xRange)
{
transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
}

if (transform.position.z < -zRange)
{
transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
}
if (transform.position.z > zRange)
{
transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
}
        
         if ( Input.GetKeyDown(KeyCode.Space))
        {
            //launchs projetile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //use offset from prototype 1 to prevent spawning from the helicopter
        }

    }
}