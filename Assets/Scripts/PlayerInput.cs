using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public KeyCode buttonPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(buttonPressed))
        {
            Debug.Log("Space bar pressed down, this runs once until released");
        }
        if (Input.GetKeyUp(buttonPressed))
        {
            Debug.Log("space bar has been pressed then released, this wont run until the release");
        }
        if (Input.GetKey(buttonPressed))
        {
            Debug.Log("The space bar is still being pressed, will run when space bar is down");
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {

        }
    }
}
