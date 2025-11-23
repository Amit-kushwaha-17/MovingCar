using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.00f;
    private float turnSpeed = 40.45f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //we will move vehicle forword here 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //moves vehical in forward/backward direction on X axis
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //moves vehical in right/left direction on Z axis
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
    }
           
 }

