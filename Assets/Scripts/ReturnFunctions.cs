using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour
{

    public int numberOne;
    public int numberTwo;
    public int playerHealth = 100;


    // Start is called before the first frame update
    void Start()
    {
        int resultOne = Multiply(numberOne, numberTwo); // return functions return values back to where they are called
        int resultTwo = Multiply(17, 6);
        int maxHealth = Random.Range(resultOne, resultTwo);
        Multiply(5, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if(IsPlayerDead() == true)
        {
            // return key inside of void functions jumps out of that function at the point and wont run the rest of the code
            return;
        }
        Debug.Log("Game is running");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerHealth = 0;
        }
    }
    // Return functions always have to return a value and it has to match the return type
    // in this case we have to return bool back

    public bool IsPlayerDead()
    {
        if(playerHealth <= 0)
        {
            Debug.Log("Player Dead");
            return true;
        }
        else
        {
            return false;
        }
    }

    // in this example we have to return an integer back in order for this to operate 
    public int Multiply(int firstNumber, int secondNumber)
    {
        Debug.Log(firstNumber * secondNumber);
        return firstNumber * secondNumber;
    }

}
