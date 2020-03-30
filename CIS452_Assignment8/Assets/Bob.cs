using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    float originalY;

    public float floatStrength = .25f; // You can change this in the Unity Editor to 
                                       // change the range of y positions that are possible.
    bool bob;
    void Start()
    {

        RandomBob();
        this.originalY = this.transform.position.y;
    }

    void Update()
    {
        if (bob)
        {
           transform.position = new Vector3(transform.position.x,
           originalY + ((float)Mathf.Sin(Time.time) * floatStrength),
           transform.position.z);

        }
        else
        {
            transform.position = new Vector3(transform.position.x,
            originalY + ((float)Mathf.Sin(-Time.time) * floatStrength),
            transform.position.z);

        }
    }

    void RandomBob()
    {
        int temp = Random.Range(1,3);

        if (temp == 1)
        {
            bob = true;
        }
    }

}