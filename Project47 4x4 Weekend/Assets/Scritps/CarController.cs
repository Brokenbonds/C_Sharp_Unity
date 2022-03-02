using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    private Image image;
    public Color colorChange;
    public Color colorChangeBack;

    public WheelCollider frontRight;
    public WheelCollider frontLeft;
    public WheelCollider backRight;
    public WheelCollider backLeft;

    public Transform frontRightTransform;
    public Transform frontLeftTransform;
    public Transform backRightTransform;
    public Transform backLeftTransform;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurn = 15f;

    public bool fourByFour = false;
    private float currentAccelration;
    public float currentBreakForce;
    private float currentTurnAngle;

    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
        ControllerUpdate();

    }
    private void Awake()
    {
        image = GameObject.Find("FourbyFourIcon").GetComponent<UnityEngine.UI.Image>();
        //This is how you find a button using theGameObject.Find method
    }
    private void Update()
    {
        if (Input.GetButtonDown("WheelFourbyFour"))
        {
            FourByFourChange();
        }
    }


     void UpdateWheel(WheelCollider col, Transform trans)
    {
        //Get WheelCollider
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        //Set the transposition and rotation

        trans.position = position;
        trans.rotation = rotation;
    }
    //This Updates the Wheels to the position and rotation of the WheelColliders to get them spinning and acting responsivly to the world
    void FourByFourChange()
    {
        fourByFour = !fourByFour;
        if (fourByFour)
        {
            image.color = colorChange;
        }
        else
        {
            image.color = colorChangeBack; ;
        }

    }
    // this turns on and off 4x4 mode and sets the button in the Canvas
    void ControllerUpdate()
    {

        // Get forward/reverse acceleration from the Vertical Axis (W and S)
        currentAccelration = acceleration * Input.GetAxis("Vertical");


        // If we are pressing space give current breaking force a value
        if (Input.GetKey(KeyCode.Space))
        {
            currentBreakForce = breakingForce * 2;
            
        }

        else
        {
            currentBreakForce = 0f;
        }
        //Apply force to Front Wheels
        frontRight.motorTorque = currentAccelration;
        frontLeft.motorTorque = currentAccelration;



        if (fourByFour)
        {
            backLeft.motorTorque = currentAccelration;
            backRight.motorTorque = currentAccelration;
        }

        ////Apply Breaking force to all wheles
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;

        //Take care of the steering.
        currentTurnAngle = maxTurn * Input.GetAxis("Horizontal");
        frontRight.steerAngle = currentTurnAngle;
        frontLeft.steerAngle = currentTurnAngle;

        UpdateWheel(backLeft, backLeftTransform);
        UpdateWheel(backRight, backRightTransform);
        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(frontRight, frontRightTransform);

    }
    
    public void Breaking()
    {

        //Apply Breaking force to all wheles
        currentBreakForce = breakingForce * 5;
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
    }
    //Breaking is used in the WinManager to stop the car
}
