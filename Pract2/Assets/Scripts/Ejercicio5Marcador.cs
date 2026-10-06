using UnityEngine;

public class Ejercicio5Marcador : MonoBehaviour
{
    public Transform objeto1;
    public Transform objeto2;
    public Transform objeto3;

    public Vector3 desplazamiento1;
    public Vector3 desplazamiento2;
    public Vector3 desplazamiento3;

    private Vector3 posicionInicial1;
    private Vector3 posicionInicial2;
    private Vector3 posicionInicial3;

    private bool teclaEspacioPulsada = false;

    void Start()
    {
        // Guardar las posiciones iniciales de los objetos
        posicionInicial1 = objeto1.position;
        posicionInicial2 = objeto2.position;
        posicionInicial3 = objeto3.position;
    }

    void Update()
    {
        // Detectar si se ha pulsado la tecla de salto (espacio)
        float jump = Input.GetAxis("Jump");

        // Si la tecla de salto (espacio) se pulsa y no estaba pulsada antes, 
        // mover los objetos a sus nuevas posiciones
        if (jump > 0.5f && !teclaEspacioPulsada)
        {
            objeto1.position = posicionInicial1 + desplazamiento1;
            objeto2.position = posicionInicial2 + desplazamiento2;
            objeto3.position = posicionInicial3 + desplazamiento3;
        }

        // Indicar si la tecla de salto (espacio) está pulsada o no
        teclaEspacioPulsada = jump > 0.5f;
    }
}