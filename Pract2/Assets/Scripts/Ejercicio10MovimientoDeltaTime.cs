using UnityEngine;

public class Ejercicio10MovimientoDeltaTime : MonoBehaviour
{
    // Velocidad de movimiento
    public float speed = 3.0f;
    // Variable para determinar si se debe usar las teclas WASD o las flechas del teclado
    public bool usarWASD = false;

    void Update()
    {
        // Variables para almacenar el valor de los ejes horizontal y vertical
        float horizontal = 0.0f;
        float vertical = 0.0f;

        // Determinar si se deben usar las teclas WASD o las flechas del teclado
        if (usarWASD)
        {
            // Obtener el valor de los ejes horizontal y vertical según las teclas WASD
            if (Input.GetKey(KeyCode.A))
                horizontal = -1.0f;

            if (Input.GetKey(KeyCode.D))
                horizontal = 1.0f;

            if (Input.GetKey(KeyCode.S))
                vertical = -1.0f;

            if (Input.GetKey(KeyCode.W))
                vertical = 1.0f;
        }
        else
        {
            // Obtener el valor de los ejes horizontal y vertical según las flechas del teclado
            if (Input.GetKey(KeyCode.LeftArrow))
                horizontal = -1.0f; 

            if (Input.GetKey(KeyCode.RightArrow)) 
                horizontal = 1.0f;

            if (Input.GetKey(KeyCode.UpArrow)) 
                vertical = 1.0f;

            if (Input.GetKey(KeyCode.DownArrow)) 
                vertical = -1.0f; 
        }

        // Mover el objeto en función de los ejes con la velocidad definida
        // Space.World para que el movimiento sea respecto al mundo y no a la orientación del objeto
        // Se multiplica por Time.deltaTime para que el movimiento sea independiente de la velocidad de fotogramas
        transform.Translate(
            horizontal * speed * Time.deltaTime,
            0.0f,
            vertical * speed * Time.deltaTime,
            Space.World
        );
    }
}