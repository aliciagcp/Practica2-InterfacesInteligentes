using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3 : MonoBehaviour
{
    public Vector3 vectorA;
    public Vector3 vectorB;

    void Update()
    {
        // Magnitud de los vectores
        float magnitudeA = vectorA.magnitude;
        float magnitudeB = vectorB.magnitude;
        Debug.Log("Magnitud de Vector A: " + magnitudeA);
        Debug.Log("Magnitud de Vector B: " + magnitudeB);

        // Ángulo entre los vectores
        float angle = Vector3.Angle(vectorA, vectorB);
        Debug.Log("Ángulo entre los vectores: " + angle + " grados");

        // Distancia entre los vectores
        float distance = Vector3.Distance(transform.position + vectorA, transform.position + vectorB);
        Debug.Log("Distancia entre los vectores: " + distance);

        // Determinar qué vector está a una altura mayor
        string higherVector = (vectorA.y > vectorB.y) ? "Vector A está más alto" : "Vector B está más alto";
        Debug.Log(higherVector);
    }
}
