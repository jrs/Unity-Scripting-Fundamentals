using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour
{
    public int Points = 100;
    public int RequiredPoints = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Standard if statement
        if (Points >= RequiredPoints)
        {
            // run code if condition is true
            LevelUpPlayer();
        }
        else
        {
            // run this code if the conditon was false
            Debug.Log("You still needed points.");
            print("This is a print");
        }
    }

    private void LevelUpPlayer()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // creating the ADD condition for our if statement
        if (collision.gameObject.CompareTag("Enemy") && collision.transform.position.y > transform.position.y)
        {
            // run this code if both conditions are true
        }

        // creating the OR condition for our if statement
        if (collision.gameObject.CompareTag("Enemy") || collision.transform.position.y > transform.position.y)
        {
            // run this code if both conditions are true
        }

    }
}
