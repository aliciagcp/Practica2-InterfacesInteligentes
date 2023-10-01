using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorObjects : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject cube;

    void Update()
    {
        // Cambia el color del cilindro cuando se presiona la tecla A
        if (Input.GetKeyDown(KeyCode.A))
        {
            Material materialCylinder = cylinder.GetComponent<Renderer>().material;
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            materialCylinder.color = randomColor;
        }

        // Cambia el color del cubo cuando se presiona la flecha arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Material materialCube = cube.GetComponent<Renderer>().material;
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            materialCube.color = randomColor;
        }
    }
}
