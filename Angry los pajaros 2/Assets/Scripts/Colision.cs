using TMPro;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private int hoyosTocados = 0;
    public TextMeshProUGUI puntaje;
    
    private void Start()
    {
        // textoFuerza.text = "Puntaje: " + hoyosTocados;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Solo destruye si el objeto que tocó se llama "EnemigoEspecial"
        if (collision.gameObject.name == "Hongo")
        {
            //(hoyosTocados == 1);

            Destroy(gameObject);

        }

    }
    /* private void OnTriggerEnter2D(Collider2D collision)
    {
       /* textoFuerza.text = "Puntaje: " + hoyosTocados;
        puntaje.text = "Puntaje: " + hoyosTocados;

        hoyosTocados = hoyosTocados + 1;
        if (hoyosTocados == 1)
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        else if (hoyosTocados == 2)
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.magenta;
        }
        else if (hoyosTocados == 3)
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
        }
        
    }
    */

}
