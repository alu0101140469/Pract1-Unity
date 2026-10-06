using UnityEngine;

public class Ejercicio11PerseguirEsfera : MonoBehaviour
{
    // Velocidad de movimiento
    public float speed = 3.0f;

    // Variable para almacenar la referencia a la esfera
    private Transform esfera;

    void Start()
    {
        // Buscar el objeto con el tag y obtener su transform
        GameObject objetoEsfera = GameObject.FindWithTag("blue_sphere");

        // Verificar si se encontró el objeto con el tag
        if (objetoEsfera != null)
        {
            esfera = objetoEsfera.transform;
        }
        else
        {
            Debug.LogError("No se encontró la esfera con el tag blue_sphere.");
        }
    }

    void Update()
    {
        // Verificar si la referencia a la esfera es válida
        if (esfera == null)
            return;

        // Calcular la dirección hacia la esfera
        Vector3 direccion = esfera.position - transform.position;

        // El cubo mantiene su altura
        direccion.y = 0.0f;

        // Normalizar la dirección para obtener un vector unitario
        if (direccion.sqrMagnitude > 0.0001f)
        {
            // Normalizar la dirección para que tenga una magnitud de 1
            direccion = direccion.normalized;

            // Mover el cubo hacia la esfera con la velocidad definida y usando Time.deltaTime
            transform.Translate(
                direccion * speed * Time.deltaTime,
                Space.World
            );
        }
    }
}