using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatments : MonoBehaviour
{
    public string myName = "Tylor";
    public int myFaveNumber = 5;
    public bool amITall = true;

    // Start is called before the first frame update
    void Start()
    {
        // greater then 3
        if(myFaveNumber > 3)
        {
            Debug.Log("five is greater then three");

        }
        // less then 5
        if(3 < myFaveNumber)
        {
            Debug.Log(" 3 is less then 5");
        }
        // less then or equal to 
        if(3 <= 3)
        {
            Debug.Log("it is less then 3");
        }
        // greater then or equal to
        if(myFaveNumber >= 3) 
        {
            Debug.Log(" it is greater then 3");
        }
        // this is the left is exactly the right
#pragma warning disable CS1718 // Comparison made to same variable
        if (myFaveNumber == myFaveNumber)
        {
            Debug.Log("5 is equal to 5");
        }
#pragma warning restore CS1718 // Comparison made to same variable
                              // as string example of the above, keep in mind its case sensitive 
        if (myName == "Tylor")
        {
            Debug.Log("Tylor");
        }
        // is the left not equal to the right
        if(myName != "tylor")
        {
            Debug.Log("this is not true due to case sensitivity");
        }

        if(amITall == true)
        {
            Debug.Log(" yes it is true");
        }
        if(amITall == false)
        {
            Debug.Log("is this false?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
