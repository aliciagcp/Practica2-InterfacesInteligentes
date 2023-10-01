using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_8 : MonoBehaviour
{
    public GameObject[] spheres;
    public GameObject cube;

    void Update()
    {
        // Calcula distancias y las agrega al vector distances
        float[] distances = new float[spheres.Length];
        for (int i = 0; i < spheres.Length; i++)
        {
            float distance = Vector3.Distance(spheres[i].transform.position, cube.transform.position);
            distances[i] = distance;
        }

        // Aumenta la altura de la esfera más cercana al cubo
        float minimumDistance = Mathf.Min(distances);
        int indexMinimumDistance = System.Array.IndexOf(distances, minimumDistance);
        GameObject nearestSphere = spheres[indexMinimumDistance];

        if (nearestSphere != null)
        {
            Vector3 newPosition = nearestSphere.transform.position;
            newPosition.y += Time.deltaTime; 
            nearestSphere.transform.position = newPosition;
        }

        // Cambia el color de la esfera más lejana al cubo cuando se presiona la tecla espacio
        float maximumDistance = Mathf.Max(distances);
        int indexMaximumDistance = System.Array.IndexOf(distances, maximumDistance);
        GameObject farthestSphere = spheres[indexMaximumDistance];

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (farthestSphere != null)
            {
                Material materialSphere = farthestSphere.GetComponent<Renderer>().material;
                Color randomColor = new Color(Random.value, Random.value, Random.value);
                materialSphere.color = randomColor;
            }
        }
    }
}
