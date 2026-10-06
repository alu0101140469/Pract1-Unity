using UnityEngine;

public class Ejercicio12LookAt : MonoBehaviour
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

        // Creamos una posición objetivo a la misma altura del cubo
        Vector3 objetivo = esfera.position;
        // Mantener la altura del cubo para que solo gire en el eje Y
        objetivo.y = transform.position.y;

        // Mirar hacia la esfera
        transform.LookAt(objetivo, Vector3.up);

        // Avanzar siguiendo el eje Z local del cubo
        transform.Translate(
            Vector3.forward * speed * Time.deltaTime,
            Space.Self
        );
        
    }
}