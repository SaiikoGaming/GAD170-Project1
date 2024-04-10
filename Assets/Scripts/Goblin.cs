using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    public string myName = "Goblin";
    public float health = 100;
    public Stats myStats = new Stats();

    // Start is called before the first frame update
    void Start()
    {
        //myStats.RandomiseStats();
        myStats = new Stats(2, 3, 5);
    }

    // Update is called once per frame
    void Update()
    {
        myStats.Move(transform);
    }
}
