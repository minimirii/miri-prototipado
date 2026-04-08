using UnityEngine;

public class Flipper : MonoBehaviour
{
    
    public HingeJoint2D jointIzq;
    private JointMotor2D motorIzq;

    // private bool Body = false;
    public Rigidbody2D BodyGameObject;

    void Start()
    {
   
        motorIzq = jointIzq.motor;

        BodyGameObject.bodyType = RigidbodyType2D.Kinematic;
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

        if (UnityEngine.InputSystem.Keyboard.current.upArrowKey.isPressed)
        {

            BodyGameObject.bodyType = RigidbodyType2D.Dynamic;
        
        }
    }
}

