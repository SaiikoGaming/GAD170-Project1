using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats
{
    // C# native classes can only hold data and functions!
    public int strength;
    public int agility;
    public int intelligence;

    public Stats()
    {

    }

    public Stats(int str, int agil, int intel)
    {
        strength = str;
        agility = agil; 
        intelligence = intel;
    }

    public void Move(Transform transformToMove)
    {
        transformToMove.position += new Vector3(0, 0, 1);
    }

    public void RandomiseStats()
    {
        strength = Random.Range(0, 10);
        agility = Random.Range(0, 10);
        intelligence = Random.Range(0, 10);
    }
}
