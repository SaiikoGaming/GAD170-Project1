using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{

    public int maxIterations = 5;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < maxIterations; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Helly Tylor");
            }
        }

        

        for (int i = maxIterations; i > 0; i--)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Helly Tylor");
            }
        }

        Debug.Log("Finished");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
