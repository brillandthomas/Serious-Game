//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
////using UnityEngine.VehiclesModule;

//public class carcontroller : MonoBehaviour
//{

//    [Serialize field] WheelCollider FrontRight;
//    [Serialize field] WheelCollider FrontLeft;
//    [Serialize field] WheelCollider BackRight;
//    [Serialize field] WheelCollider BackLeft;


//    public float Acceleration = 500f;
//    public float BreakingForce = 300f;
//    public float MaxTurnangle = 20f;

//    public float CurrentAcceleration = 0f;
//    public float CurrentBreakingForce = 0f;
//    public float CurrentMaxTurnangle = 0f;

//    private void FixedUpdate()

//    {
//        //CurrentAcceleration = Acceleration * Input.GetAxis("Vertical");
//        if (Input.GetKey(KeyCode.UpArrow))
//        {
//            CurrentAcceleration = Acceleration; 
//        }
//        else
//        {
//            CurrentAcceleration = 0;
//        }

//        if (Input.GetKey(KeyCode.Space))
//            CurrentBreakingForce = BreakingForce;
//        else
//            CurrentBreakingForce = 0f;

//        FrontRight.motorTorque = CurrentAcceleration;
//        FrontLeft.motorTorque = CurrentAcceleration;

//        FrontRight.brakeTorque = CurrentBreakingForce;
//        FrontLeft.brakeTorque = CurrentBreakingForce;
//        BackRight.brakeTorque = CurrentBreakingForce;
//        BackLeft.brakeTorque = CurrentBreakingForce;

//        float CurrentTurnAngle = MaxTurnangle * Input.GetAxis("Horizontal");
//        FrontLeft.steerAngle = CurrentTurnAngle;
//        FrontRight.steerAngle = CurrentTurnAngle;



//    }


//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
