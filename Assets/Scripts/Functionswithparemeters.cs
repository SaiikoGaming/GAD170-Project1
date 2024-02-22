using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functionswithparemeters : MonoBehaviour
{
    public string firstName = "Tylor";
    public string lastName = "Pahl";

    // Start is called before the first frame update
    void Start()
    {
        PrintMyName(firstName, lastName, 18);
        PrintMyName("TJ", "Jones", 17);
        PrintMyName("Garry", "Snail");
        PrintMyName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //string nameOne = firstName
    // string nameTwo = lastName
    public void PrintMyName(string nameOne = "Zombie", string nameTwo = "Creeper", int age = 16)
    {
        Debug.Log(nameOne + " " +  nameTwo);
        Debug.Log("their age is: " +  age);
    }

}
