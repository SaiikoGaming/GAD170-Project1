using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVariables : MonoBehaviour
{
    public string mName = "Tylor";
    public int myHealth = 100;
    private float myHeight = 155.23f;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("current health is: " + myHealth);
        int temporaryHealth = 0; // local/temp veriables only exist between the curley or lower curley braces they are defined.
        //maybe i take some poisen damage 
        temporaryHealth = myHealth; // grab the current value of my health at this its 100
        //maybe it reduces my health for a short period of time
        myHealth = myHealth - 20; // my health is currently 80, however the temporary helath is still 100
        Debug.Log("current health is: " + myHealth + "the temporary health is " + temporaryHealth);
        //after say 5 seconds my health regens to its previous point
        // i want to restore my health to its previous point
        myHealth = temporaryHealth; // my health resets back to 100
        Debug.Log("current health is: " + myHealth);

        // check to see if my name is tylor and print out the current value
        if(mName == "tylor")
        {
            Debug.Log("current health is: " + myHealth + " the temp health is " + temporaryHealth);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
