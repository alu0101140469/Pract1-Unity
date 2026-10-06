using UnityEngine;

public class Ejercicio7Disparo : MonoBehaviour
{
    void Update()
    {
        // Detectar si se presiona el botón de disparo (ahora tecla H)
        if (Input.GetButtonDown("Fire1"))
        {
            Disparo();
        }
    }

    void Disparo()
    {
        // Comprobar si se presiona la tecla H para disparar
        Debug.Log("Disparo");
    }
}