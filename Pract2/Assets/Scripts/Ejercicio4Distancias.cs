using UnityEngine;

public class Ejercicio4Distancias : MonoBehaviour
{
    private GameObject esfera;
    private GameObject cubo;
    private GameObject cilindro;

    void Start()
    {
        // Buscamos los objetos mediante sus etiquetas
        esfera = GameObject.FindWithTag("blue_sphere");
        cubo = GameObject.FindWithTag("cube");
        cilindro = GameObject.FindWithTag("cylinder");

        // Comprobamos que los objetos existen
        if (esfera == null)
        {
            Debug.LogError("No se encontró la esfera.");
            return;
        }

        if (cubo == null)
        {
            Debug.LogError("No se encontró el cubo.");
            return;
        }

        if (cilindro == null)
        {
            Debug.LogError("No se encontró el cilindro.");
            return;
        }

        // Obtenemos sus posiciones
        Vector3 posicionCubo = cubo.transform.position;
        Vector3 posicionCilindro = cilindro.transform.position;

        // Calculamos la distancia
        float distancia = Vector3.Distance(
            posicionCubo,
            posicionCilindro
        );

        Debug.Log("Distancia entre el cubo y el cilindro: " + distancia);
    }
}