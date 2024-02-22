using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge4 : MonoBehaviour
{

    public int statPool = 20;
    public int randomNumber = 0;
    public int strength = 0;
    public int agility = 0;
    public int intelligence = 0;
    






    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, statPool);

        Debug.Log("Statpool: " + statPool);

        strength = randomNumber;
        statPool = statPool - randomNumber;
        Debug.Log("Strength: " + strength + " Statpool: " + statPool);

        randomNumber = Random.Range(0, statPool);
        agility = randomNumber;
        statPool = statPool - randomNumber;
        Debug.Log("Agility: " + agility + " Statpool: " + statPool);

        randomNumber = Random.Range(0, statPool);
        intelligence = randomNumber;
        statPool = statPool - randomNumber;
        Debug.Log("Intelligence: " + intelligence + " Statpool: " + statPool);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            statPool = statPool + 20;
            randomNumber = Random.Range(0, statPool);

            Debug.Log("Statpool: " + statPool);

            strength = strength + randomNumber;
            statPool = statPool - randomNumber;
            Debug.Log("Strength: " + strength + " Statpool: " + statPool);

            randomNumber = Random.Range(0, statPool);
            agility = agility + randomNumber;
            statPool = statPool - randomNumber;
            Debug.Log("Agility: " + agility + " Statpool: " + statPool);

            randomNumber = Random.Range(0, statPool);
            intelligence = intelligence + randomNumber;
            statPool = statPool - randomNumber;
            Debug.Log("Intelligence: " + intelligence + " Statpool: " + statPool);

        }
    }

    


}
