using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{   
    public bool greenLight = false;
    public float duree_redlight = 10;
    public float duree_greenlight = 10;
    public float last_update = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (greenLight)
        {
            if (Time.fixedTime > duree_redlight + last_update)
            {
                greenLight = false;
                last_update = Time.fixedTime;
            }
        }
        else
        {
            if (Time.fixedTime > duree_greenlight + last_update)
            {
                greenLight = true;
                last_update = Time.fixedTime;
            }
        }
    }
}