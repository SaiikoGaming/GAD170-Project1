using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge2 : MonoBehaviour
{

    public string myFavouriteGame = "GTA V";
    public int hoursPlayed = 1600;
    public float cost = 100f;
    


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My favourite game is " + myFavouriteGame);
        Debug.Log("i have played it for " + hoursPlayed + "hours");
        Debug.Log("it cost me $" + cost);
        Debug.Log("therefore my value of dollar per hour is $" + (cost / hoursPlayed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
