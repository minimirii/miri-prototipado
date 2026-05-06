using UnityEngine;

[CreateAssetMenu(fileName = "Herramienta", menuName = "Scriptable Objects/Herramienta")] //crear herramientas del tool, crear desde el editor
public class Herramienta : ScriptableObject // heredar
{
    public string nombre;
    public Sprite sprite;
}
