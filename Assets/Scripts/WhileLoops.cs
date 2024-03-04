using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int maxIterations = 10;
    public bool startGame = false;
    // Start is called before the first frame update
    void Start()
    {
        int currentValue = 0;
        while (currentValue < maxIterations)
        {
            Debug.Log("Helly Tylor");
            currentValue += 1;
        }



        Debug.Log("Starting Game");
    }

    // Update is called once per frame
    void Update()
    {
           
    }
}
