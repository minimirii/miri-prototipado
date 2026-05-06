using UnityEngine;
using System.Collections.Generic;
using JetBrains.Annotations;

public class HerramientasManager : MonoBehaviour
{
    public List<Herramienta> misHerramientas;
    public SpriteRenderer herramienta1;
    public SpriteRenderer herramienta2;
    public SpriteRenderer herramienta3;
    public SpriteRenderer herramienta4;
    string nombre;
    string dialogo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        herramienta1.sprite = misHerramientas[0].sprite;
        herramienta2.sprite = misHerramientas[1].sprite;
        herramienta3.sprite = misHerramientas[2].sprite;
        herramienta4.sprite = misHerramientas[3].sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}