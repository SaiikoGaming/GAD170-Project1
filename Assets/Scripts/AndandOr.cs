using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndandOr : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        int randomNumber = Random.Range(0, 10);

        // this checks if a number is between 0 and 5
        if (randomNumber > 0)
        {
            if (randomNumber < 5)
            {
                Debug.Log("the number is between 0 and 5");
            }
        }
        
        // this does the same as above but uses the && and operator
        if (randomNumber > 0 && randomNumber < 5)
        {
            Debug.Log("the number is between 0 and 5");
        }

        // this code is saying if the number is less than 6 or less than 8 do this
        if (randomNumber < 6 || randomNumber < 8 || randomNumber > 0)
        {
            Debug.Log("the number was less than 6 or less than 8");
        }

        // this is the longer version of the above code
        if (randomNumber < 6)
        {
            Debug.Log("the number was less than 6 or less than 8");

        }
        else if (randomNumber < 8)
        {
            Debug.Log("the number was less than 6 or less than 8");

        }
        else if (randomNumber > 0)
        {
            Debug.Log("the number was less than 6 or less than 8");

        }

        // And and Or together
        if(randomNumber < 8 || (randomNumber > 0 && randomNumber < 5))
        {
            Debug.Log("if the number is less then 8 OR the number is greater then 0 AND less then 5");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
