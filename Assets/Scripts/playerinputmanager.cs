using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinputmanager : MonoBehaviour
{
    public Player playerOne;
    public Player playerTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // attack called
            playerOne.Attack();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // defense is called
            playerOne.Defend();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            // if a reference to this script exists then call the function or variable
            if(playerTwo != null)
            {
                playerTwo.Attack();
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            // defense is called
            playerTwo.Defend();
        }

    }
}
