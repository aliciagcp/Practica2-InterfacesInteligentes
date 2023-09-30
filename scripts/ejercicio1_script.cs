using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public int minimum = 0;
    public int maximum = 25;
    public int size_vector = 10;
    int[] numbers;

    // Start is called before the first frame update
    void Start()
    {
        numbers = new int[size_vector];
        for (int i = 0; i < size_vector; i++) {
            numbers[i] = Random.Range(minimum, maximum + 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        int random_position = Random.Range(0, size_vector);
        int new_number = Random.Range(minimum, maximum + 1);
        numbers[random_position] = new_number;
        for (int i = 0; i < size_vector; i++) {
            if (numbers[i] > 15) { Debug.Log("Position: " + i + " Number: " + numbers[i]); }
        }
        
    }
}
