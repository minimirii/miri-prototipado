using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class UsodeInputActions : MonoBehaviour
{
    private Control InputActions;

    private void Awake()
    {
        InputActions = new Control();

    }

    private void OnEnable()
    {
        InputActions.Pajaros.Enable();
        InputActions.Pajaros.presionado.started += LePico;
        InputActions.Pajaros.Clic.performed += LePico;
        InputActions.Pajaros.presionado.started += LePico;
        // InputActions.Pajaros.Posicion.ReadValue<Vector2>(); //mouse
    }
    private void OnDisable()
    {
        InputActions.Disable();
    }

    void LePico(InputAction.CallbackContext handler)
    {
        print("PICO");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
