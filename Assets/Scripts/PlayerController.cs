using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward
        //removed because of usage, but is similar: transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward*Time.deltaTime*speed);//With deltaTime we can control how much time is actually passing, this makes forward(0,0,20) for a second
        Debug.Log(transform.position);
               
    }
}
