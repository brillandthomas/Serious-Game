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

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<TrafficLight>() != null)
        {
            TrafficLight trafficLightObject = other.gameObject.GetComponent<TrafficLight>();
            if (trafficLightObject.greenLight) 
                isMoving = true;
            else 
                isMoving = false;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.GetComponent<CarAutomated>() != null)
        {
            CarAutomated CarObject = other.gameObject.GetComponent<CarAutomated>();

            if (CarObject.isMoving)
            {
                speed = CarObject.speed;
            }
            else
            {
                isMoving = false;
            }
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CarAutomated>() != null)
            isMoving = true;

    }
}