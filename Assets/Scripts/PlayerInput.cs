using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // checks to see if the button has pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space bar pressed down, this runs once until released");
        }
        // checks to see if the button is pressed 
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("space bar has been pressed then released");
        }
        // checks to see if the button is released
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("The space bar is still being pressed, will run when space bar is down");
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {

        }
    }
}
