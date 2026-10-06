using UnityEngine;

public class Ejercicio2Vectores : MonoBehaviour
{
    // Vectores configurables desde el Inspector
    public Vector3 vector1;
    public Vector3 vector2;

    // Resultados que aparecerán en el Inspector
    public float magnitudVector1;
    public float magnitudVector2;
    public float angulo;
    public float distancia;
    public string vectorMasAlto;

    void Start()
    {
        CalcularDatos();
    }

    void CalcularDatos()
    {
        // Magnitudes
        magnitudVector1 = vector1.magnitude;
        magnitudVector2 = vector2.magnitude;

        // Ángulo entre los vectores
        angulo = Vector3.Angle(vector1, vector2);

        // Distancia entre ambos
        distancia = Vector3.Distance(vector1, vector2);

        // Qué vector tiene mayor altura
        if (vector1.y > vector2.y)
        {
            vectorMasAlto = "El vector 1 está a mayor altura.";
        }
        else if (vector2.y > vector1.y)
        {
            vectorMasAlto = "El vector 2 está a mayor altura.";
        }
        else
        {
            vectorMasAlto = "Los dos vectores están a la misma altura.";
        }

        // Mostrar resultados en consola
        Debug.Log("Magnitud Vector 1: " + magnitudVector1);
        Debug.Log("Magnitud Vector 2: " + magnitudVector2);
        Debug.Log("Ángulo entre los vectores: " + angulo + " grados");
        Debug.Log("Distancia entre los vectores: " + distancia);
        Debug.Log(vectorMasAlto);
    }
}