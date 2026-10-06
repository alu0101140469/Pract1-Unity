using UnityEngine;

public class Ejercicio13AvanzarGirar : MonoBehaviour
{
    // Velocidad de movimiento
    public float speed = 3.0f;

    // Velocidad de rotación
    public float rotationSpeed = 90.0f;

    void Update()
    {
        // Obtener el valor del eje horizontal
        float horizontal = Input.GetAxis("Horizontal");

        // Girar sobre el eje Y
        transform.Rotate(
            0.0f,
            horizontal * rotationSpeed * Time.deltaTime,
            0.0f,
            Space.World // Para que la rotación sea respecto al mundo y no a la orientación del objeto
        );

        // Avanzar siempre hacia delante
        transform.Translate(
            transform.forward * speed * Time.deltaTime,
            Space.World
        );

        // Línea de depuración que representa el forward
        Debug.DrawRay(
            transform.position,
            transform.forward * 2.0f
        );
    }
}