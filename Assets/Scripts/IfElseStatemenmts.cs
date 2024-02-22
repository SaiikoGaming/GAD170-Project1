using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatemenmts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // generate a random number
        int randomNumber = Random.Range(0, 10);

        // if the number is less then or equal to 5
        if(randomNumber <= 5)
        {
            Debug.Log("The number is less then 5");
        }
        else
        {
            Debug.Log("the number is greater then 3");
            if(randomNumber > 7)
            {
                Debug.Log("Number is more than 7");
            }
            else
            {
                Debug.Log("The number is less than 7");
            }
        }
        Debug.Log("Program Completed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
