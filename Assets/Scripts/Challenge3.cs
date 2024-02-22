using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge3 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        // creates a random float between 0f and 10f
        float randomNumber = Random.Range (0f, 10f);

        Debug.Log(randomNumber);

        if (randomNumber == 1)
        {
            Debug.Log("The number was exactly 1");
        }
        
        if (randomNumber > 3) 
        {
            Debug.Log("The number was greater then 3");
        }

        if (randomNumber > 7 || randomNumber < 5)
        {
            Debug.Log("The number was greater then 7 or less then 5");
        }
        else
        {
            Debug.Log("The number was 6 or 7");
        }

        if((randomNumber > 1 && randomNumber > 5) || randomNumber > 5)
        {
            Debug.Log("The number was greater then 1 and less than 5; or the number was greater then 5");
        }

        Debug.Log(randomNumber / 10 * 100 + "%");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
