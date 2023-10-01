using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_6 : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject cube;

    void Update()
    {
        // Alinea el cilindro 5 unidades a la derecha de la esfera en el eje X
        Vector3 newCylinderPosition = transform.position + new Vector3(5f, 0f, 0f);
        cylinder.transform.position = newCylinderPosition;

        // Alinea el cubo 5 unidades a la izquierda de la esfera en el eje X
        Vector3 newCubePosition = transform.position - new Vector3(5f, 0f, 0f);
        cube.transform.position = newCubePosition;
    }
}
