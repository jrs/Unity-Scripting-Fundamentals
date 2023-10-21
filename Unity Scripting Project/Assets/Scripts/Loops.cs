using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // For Loop Example
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Iteration: " + i);
        }

        //While Loops Example
        int num = 0;
        while (num < 5)
        {
            Debug.Log("Number: " + num);
            num++;
        }

        //Foreach Loop Example
        string[] fruits = { "Apple", "Banana", "Orange" };
        foreach (string fruit in fruits)
        {
            Debug.Log("Fruit: " + fruit);
        }

        //Do-While Loop
        int x = 0;

        do
        {
            Debug.Log("Value of x: " + x);
            x++;
        } while (x < 3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
