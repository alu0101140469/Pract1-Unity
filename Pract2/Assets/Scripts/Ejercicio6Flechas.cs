using UnityEngine;

public class Ejercicio6Flechas : MonoBehaviour
{
    // Velocidad de movimiento
    public float speed = 5.0f;

    void Update()
    {
        // Obtener el valor de los ejes horizontal y vertical
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Mover el objeto en función de los ejes con la velocidad definida
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Mover hacia arriba
            Debug.Log("Flecha Arriba: " + (speed * vertical));
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Mover hacia abajo
            Debug.Log("Flecha Abajo: " + (speed * vertical));
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Mover hacia la izquierda
            Debug.Log("Flecha Izquierda: " + (speed * horizontal));
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Mover hacia la derecha
            Debug.Log("Flecha Derecha: " + (speed * horizontal));
        }
    }
}