using UnityEngine;

public class Flipper : MonoBehaviour
{
    
    public HingeJoint2D jointIzq;
    private JointMotor2D motorIzq;
    void Start()
    {
   
        motorIzq = jointIzq.motor;
    }

    // Update is called once per frame
    void Update()
    {


        if (UnityEngine.InputSystem.Keyboard.current.spaceKey.isPressed)
        {
            motorIzq.motorSpeed = 3000;
        }
        else
        {
            motorIzq.motorSpeed = -1000;
        }
        jointIzq.motor = motorIzq;
    }
}

