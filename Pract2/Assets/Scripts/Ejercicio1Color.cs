using UnityEngine;

public class Ejercicio1Color : MonoBehaviour
{
    // Número de frames que esperamos antes de cambiar el color
    public int framesEspera = 120;

    // Vector que utilizaremos como color RGB
    public Vector3 vectorColor;

    // Contador de frames
    private int contadorFrames = 0;

    private Renderer objetoRenderer;

    void Start()
    {
        // Inicializamos el vector con valores entre 0 y 1
        vectorColor = new Vector3(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f)
        );

        // Obtenemos el Renderer del objeto
        objetoRenderer = GetComponent<Renderer>();

        // Aplicamos el color inicial
        AplicarColor();
    }

    void Update()
    {
        contadorFrames++;

        if (contadorFrames >= framesEspera)
        {
            // Elegimos aleatoriamente una de las 3 posiciones
            int posicion = Random.Range(0, 3);

            // Cambiamos solamente esa componente
            float nuevoValor = Random.Range(0.0f, 1.0f);

            if (posicion == 0)
            {
                vectorColor.x = nuevoValor;
            }
            else if (posicion == 1)
            {
                vectorColor.y = nuevoValor;
            }
            else
            {
                vectorColor.z = nuevoValor;
            }

            // Aplicamos el nuevo color
            AplicarColor();

            // Reiniciamos el contador
            contadorFrames = 0;
        }
    }

    void AplicarColor()
    {
        Color color = new Color(
            vectorColor.x,
            vectorColor.y,
            vectorColor.z
        );

        objetoRenderer.material.color = color;
    }
}