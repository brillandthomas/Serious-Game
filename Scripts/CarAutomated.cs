using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAutomated : MonoBehaviour
{
    public float maxSpeed = 20;
    public bool isMoving = false;
    float speed = 0;


    void Start()
    {

        isMoving = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            speed = maxSpeed;

        }
        else
            speed = 0;


        transform.position += transform.forward * speed * Time.deltaTime;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<TrafficLight>() != null)
            isMoving = false;
    }
}