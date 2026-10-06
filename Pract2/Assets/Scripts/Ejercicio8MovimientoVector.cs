using UnityEngine;

public class Ejercicio8MovimientoVector : MonoBehaviour
{
    // Vector de movimiento y velocidad
    public Vector3 moveDirection = new Vector3(0.01f, 0.0f, 0.0f);
    public float speed = 2.0f;

    // Variable para determinar si se debe usar el espacio de coordenadas global o local
    public bool usarEspacioMundo = false;

    void Update()
    {
        Space espacio;

        // Determinar si se debe usar el espacio de coordenadas global o local
        if (usarEspacioMundo)
        {
            // Usar el sistema de ejes global
            espacio = Space.World;
        }
        else
        {
            // Usar el sistema de ejes local
            espacio = Space.Self;
        }

        // Mover el objeto en función del vector de movimiento, 
        // la velocidad y el espacio de coordenadas seleccionado
        transform.Translate(
            moveDirection.x * speed,
            moveDirection.y * speed,
            moveDirection.z * speed,
            espacio
        );
    }
}