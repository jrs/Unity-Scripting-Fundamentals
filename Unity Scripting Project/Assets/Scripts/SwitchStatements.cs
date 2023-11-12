using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour
{
    public string Character = "John";

    // Start is called before the first frame update
    void Start()
    {
        switch (Character)
        {
            case "John":
            Debug.Log("John was selected.");
            break;
            case "Tom":
            Debug.Log("Tom was selected.");
            break;
            case "Lenny":
            Debug.Log("Lenny was selected.");
            break;
            default:
            Debug.Log("Invalid character selected.");
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
