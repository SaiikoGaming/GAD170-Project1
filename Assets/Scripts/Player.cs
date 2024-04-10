using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float health = 0;
    public string myName;
    public Stats myStats = new Stats();


    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(0, 100);
        myStats.RandomiseStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {
        Debug.Log(myName + " attacked");
    }

    public void Defend()
    {
        Debug.Log(myName + " defended");
    }
}
