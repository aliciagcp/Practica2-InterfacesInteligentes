using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5 : MonoBehaviour
{
     void Update()
    {
        // Encuentra los objetos con las etiquetas "Cube" y "Cylinder"
        GameObject cube = GameObject.FindWithTag("Cube");
        GameObject cylinder = GameObject.FindWithTag("Cylinder");

        // Verifica si se encontraron los objetos
        if (cube != null && cylinder != null)
        {
            // Obtiene los componentes Transform de los objetos del cubo y del cilindro
            Transform cubeTransform = cube.transform;
            Transform cylinderTransform = cylinder.transform;

            // Obtiene las posiciones de los objetos del cubo y del cilindro
            Vector3 positionCube = cubeTransform.position;
            Vector3 positionCylinder = cylinderTransform.position;

            // Distancia entre el cubo y la esfera
            float distanceCubeSphere = Vector3.Distance(transform.position, positionCube);
            Debug.Log("Distancia entre el cubo y la esfera: " + distanceCubeSphere);

            // Distancia entre el cilindro y la esfera
            float distanceCylinderSphere = Vector3.Distance(transform.position, positionCylinder);
            Debug.Log("Distancia entre el cilindro y la esfera: " + distanceCylinderSphere);

            // Distancia entre el cubo y el cilindro
            float distanceCubeCylinder = Vector3.Distance(positionCube, positionCylinder);
            Debug.Log("Distancia entre el cubo y el cilindro: " + distanceCubeCylinder);
        }
        else
        {
            Debug.LogError("No se encontraron objetos con las etiquetas Cube o Cylinder.");
        }
    }
}
