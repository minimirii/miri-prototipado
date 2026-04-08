using UnityEngine;

public class Fisica : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 fuerzaAplicada;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fuerzaAplicada = new Vector2(5f, 10f);
            rb.AddForce(fuerzaAplicada, ForceMode2D.Impulse);
        }
    }
}
