using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintObjectName : MonoBehaviour
{
    public GameObject plane;
    public GameObject cube;
    public GameObject sphere;
    public GameObject cylinder;

    void Start()
    {
        // Muestra los nombres de los objetos en la consola
        Debug.Log("Nombre del Plano: " + plane.name);
        Debug.Log("Nombre del Cubo: " + cube.name);
        Debug.Log("Nombre de la Esfera: " + sphere.name);
        Debug.Log("Nombre del Cilindro: " + cylinder.name);
    }
}
