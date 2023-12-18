using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsAndMethods : MonoBehaviour
{
    public int Score = 0;

    private int _playerHealthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Method Examples

    // This method is accessable from other files because it is Public
    public void UpdatePlayerHealth(int amount)
    {
        _playerHealthAmount -= amount;
    }

    // This method is not accessable from other files
    private void IncreseScore()
    {
        Score++; // Score = Score + 1;
    }

    private void MovePlayer()
    {
        transform.Translate(Vector3.forward);
    }
    
}
