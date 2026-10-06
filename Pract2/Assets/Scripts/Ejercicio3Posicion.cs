using UnityEngine;

public class Ejercicio3Posicion : MonoBehaviour
{
    private Transform miTransform;

    void Start()
    {
        // Obtenemos la referencia al Transform
        miTransform = GetComponent<Transform>();
    }

    void OnGUI()
    {
        Vector3 posicion = miTransform.position;

        // Mostrar por pantalla
        GUI.Label(
            new Rect(20, 20, 500, 30),
            "Posición de la esfera: " + posicion
        );
    }
}