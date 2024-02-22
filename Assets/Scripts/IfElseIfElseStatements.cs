using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseIfElseStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get a random number
        int randomNumber = Random.Range(0, 10);

        // lets imagine the number is 2
        if(randomNumber > 5) // is 2 greater then 5
        {
            Debug.Log("the number is greater than 5");
        }
        else if(randomNumber < 3) // is 2 less then 3? yes, so run this code
        {
            Debug.Log("the number is less then 3");
        }
        else if (randomNumber < 4) // the rest of these get skipped.
        {
            Debug.Log(" the number is less then 4");
        }
        else 
        {
            Debug.Log("the number is greater than 1");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
