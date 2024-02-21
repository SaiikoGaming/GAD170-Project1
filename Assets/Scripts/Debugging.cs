using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugg : MonoBehaviour
{
    public string myName = "Tylor";
    public int myAge = 23;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi TJ");
        Debug.Log("current age = "+myAge);

        Debug.LogWarning("uh oh");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
