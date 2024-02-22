using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public string myFirstName = "Tylor";
    public string mySecondName = " Lee";

    // Start is called before the first frame update
    void Start()
    {

        // call my print name function 
        PrintMyName();
        
        // this is an example as a local function/ temporary function 
        void HelloWorld()
        {
            Debug.Log("HelloWorld");
        }

        HelloWorld();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// print my name creates a string that is the first name and my last name joined
    /// </summary>
    public void PrintMyName()
    {
        string fullName = myFirstName + " " + mySecondName;
        Debug.Log("my name is: " + fullName);
        // an exampe of calling a function from another function 
        PrintMyAge();
    }

    public void PrintMyAge()
    {
        Debug.Log(18);
    }

}
