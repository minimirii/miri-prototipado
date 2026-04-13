using UnityEngine;

public class Flipper : MonoBehaviour
{
    
    public HingeJoint2D jointIzq;
    private JointMotor2D motorIzq;

    // private bool Body = false;
    public Rigidbody2D BodyGameObject;
    public GameObject Enemigo;

    private Control InputActions;

    private void Awake()
    {
        InputActions = new Control();

    }

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
            motorIzq.motorSpeed = 4000;
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

