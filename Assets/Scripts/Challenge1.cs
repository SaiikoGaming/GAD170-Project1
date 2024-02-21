using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge1 : MonoBehaviour
{

    public string myName = "Tylor";
    public int myAge = 18;
    public float myHeight = 155.45f;
    public bool isWearingAWatch = false;
    public int myFaveNumber = 23;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi my name is: " + myName);
        Debug.Log("My age is: " + myAge);
        Debug.Log("I am " + myHeight + " centimeters tall");
        Debug.Log("The rumours going around that i am wearing a watch are: " +  isWearingAWatch);
        Debug.Log("My favourite number is: " + myFaveNumber);
        Debug.Log("If my age was added to my favourite number, and subtracted my height it would give me: " + (myAge + myFaveNumber - myHeight));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
