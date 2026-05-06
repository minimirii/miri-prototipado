using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PieceHandler : MonoBehaviour
{
    private Control misControles;
    private GameObject piezaGolpeada;
    private void Awake()
    {
        misControles = new Control();
    }

    private void OnEnable()
    {
        misControles.Pajaros.Enable();
        misControles.Pajaros.presionado.started += Presiono;
        misControles.Pajaros.presionado.canceled += Presiono;
    }

    private void OnDisable()
    {
        misControles.Pajaros.Disable();
    }

    private void Presiono(InputAction.CallbackContext handler)
    {
        Vector2 coordenadasDeMouseAMundo = Camera.main.ScreenToWorldPoint(misControles.Pajaros.Position.ReadValue<Vector2>());
        RaycastHit2D golpeo = Physics2D.Raycast(coordenadasDeMouseAMundo, coordenadasDeMouseAMundo);
        if (golpeo)
        {
            print("Golpeo a " + golpeo.collider.name);
            piezaGolpeada = golpeo.collider.gameObject;
            
        }
    }
    private void Suelto(InputAction.CallbackContext handler, Vector2 coordenadas)
    {
        piezaGolpeada = null;
    }

    void Update()
    {
        if (piezaGolpeada != null)
        {
            piezaGolpeada.transform.position = Vector2.Lerp(piezaGolpeada.transform.position, Camera.main.ScreenToWorldPoint(misControles.Pajaros.Position.ReadValue<Vector2>()), 0.1f);
        }

        if (Mouse.current.rightButton.isPressed && piezaGolpeada != null)
        {
             Vector2 coordenadasDeMouseAMundo = Camera.main.ScreenToWorldPoint(misControles.Pajaros.Position.ReadValue<Vector2>());
             piezaGolpeada.transform.position = coordenadasDeMouseAMundo;
        }
    }
}
