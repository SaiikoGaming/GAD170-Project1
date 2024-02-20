using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// class holds all info for variables
/// </summary>
public class Variables : MonoBehaviour
{
    #region code neatness tutorial 


    // single line comment

    /* multi line 
     * comment
     */
    [Tooltip("this bool holds trueor false")]
    public bool myfirstbool = true;
    [Header("movement relatable")]
    public bool mysecondbool = false;
    #endregion

    public int myFirstInt = 1; // an int can only hold whole numbers (1,2,3)
    private float myHeight = 180.67f; // a float holds decimal numbers (f = decimal/float)
    public double myFaveNumber = 187.45; // a double holds double a float (many more decimal points)
    public string myName = "Tylor"; // a string can only hold words
    public char myInitial = 's'; // a char can only hold a single character 
    public bool isWearingAWatch = false; // a bool can only hold true or false


    #region all unity functions
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
