using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// class holds all info for variables
/// </summary>
public class Variables : MonoBehaviour
{
    // single line comment

    /* multi line 
     * comment
     */
    [Tooltip("this bool holds trueor false")]
    public bool myfirstbool = true;
    [Header("movement relatable")]
    public bool mysecondbool = false;


    #region all unity functions
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
