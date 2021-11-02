using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //Move the vehicle forward
        //removed because of usage, but is similar: transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward*Time.deltaTime*speed);//With deltaTime we can control how much time is actually passing, this makes forward(0,0,20) for a second
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed* horizontalInput);   //Vector3.right equals (1,0,0), this formel means that our vehicle moves (turnSpeed,0,0) per second   


    }
}
