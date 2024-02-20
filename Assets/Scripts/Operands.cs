using System.Collections;
using System.Collections.Generic;
using UnityEditor.AI;
using UnityEngine;

public class Operands : MonoBehaviour
{
    public int numberOne = 3; // my first number to use
    public int numberTwo = 4; // my second number to use 
    public int result = 0; // the result of my operations to the next set of numbers


    // Start is called before the first frame update
    void Start()
    {
        /* operands are
         *  = is assigning values
         *  + is our addition
         *  - is our subtraction 
         *  * is our multiplication 
         *  / is our division 
         *  () is our order of operations
         *  % is our modulo or modulous operation
         */

        // () = parenthesis determine order of execution 
        // {} = curly braces define scope of my functional class
        // [] = square brackets allow to access elements of a collection


        //result = numberOne + numberTwo; // the result variable is set to the value of 3 plus 4
        //result = numberOne - numberTwo; // the result variable is set to the value of 3 subtract 4
        //result = numberOne * numberTwo; // the result variable is set to the value of 3 multiplied by 4
        //result = numberOne / numberTwo; // the reuslt variable is set to the value of 3 divided by 4 (int can only give out whole numbers)
        //BOMDAS Brackets, Order if operations, multiplication, division, addition, subtraction
        //result = ((numberOne + numberTwo) * numberOne); // our parenthesis determine the oder of operation
        //result = numberOne % numberTwo; // this will result in the remainder of this calculation


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
