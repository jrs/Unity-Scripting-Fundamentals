using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsAndMethods : MonoBehaviour
{
    private float _speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(AddTwoNumbers(4, 9));
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayerForward();
    }

    // Method to move the player forward
    private void MovePlayerForward()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    // Method to return a number
    private int AddTwoNumbers(int num1, int num2)
    {
        return num1 + num2;
    }
}
