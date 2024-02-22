using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge5 : MonoBehaviour
{
    int playerOneHealth = 0;
    int playerOneStrength = 0;
    int playerOneAgility = 0;
    int playerOneIntelligence = 0;
    int playerOnePowerLevel = 0;

    int playerTwoHealth = 0;
    int playerTwoStrength = 0;
    int playerTwoAgility = 0;
    int playerTwoIntelligence = 0;
    int playerTwoPowerLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        SetPlayerOneStats();
        SetPlayerTwoStats();
    }

    // Update is called once per frame
    void Update()
    {
        Battle();
    }

    void SetPlayerOneStats()
    {
        // set our health to 100
        playerOneHealth = 100;
        // set our stats to random numbers between 0 - 10
        playerOneStrength = Random.Range(1, 10);
        playerOneAgility = Random.Range(1, 10);
        playerOneIntelligence = Random.Range(1, 10);
        Debug.Log("Player One's Stats: Health: " + playerOneHealth + " Strength: " + playerOneStrength + " Agility: " + playerOneAgility + " Intelligence: " + playerOneIntelligence);  

    
    }

    void SetPlayerTwoStats()
    {
        // set our health to 100
        playerTwoHealth = 100;
        // set our stats to random numbers between 0 - 10
        playerTwoStrength = Random.Range(1, 10);
        playerTwoAgility = Random.Range(1, 10);
        playerTwoIntelligence = Random.Range(1, 10);
        Debug.Log("Player Two's Stats: Health: " + playerTwoHealth + " Strength: " + playerTwoStrength + " Agility: " + playerTwoAgility + " Intelligence: " + playerTwoIntelligence);

    }

    void Battle()
    {
        if (playerOneHealth <= 0 || playerTwoHealth <= 0) 
        {
            Debug.Log("Battle can not commence");
            return;
        }
        else if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("Battle Commmencing");
            playerOnePowerLevel = GeneratePowerLevel(playerOneIntelligence, playerOneAgility, playerOneStrength);
            playerTwoPowerLevel = GeneratePowerLevel(playerTwoIntelligence, playerTwoAgility, playerTwoStrength);
            Debug.Log("PlayerOnePowerLevel: " + playerOnePowerLevel);
            Debug.Log("PlayerTwoPowerLevel: " + playerTwoPowerLevel);
            DetermineWinner(playerOnePowerLevel, playerTwoPowerLevel);
            
        }
         
    }

    int GeneratePowerLevel(int intel, int agil, int strength)
    {
        // lets do some sort of algorithm here i.e. intel + agil + strength, its probably a good idea to asdd some randomness here too,
        // otherwise the same player will always win most likely 
        playerOnePowerLevel = intel + agil + strength + Random.Range(0, 5);
        playerTwoPowerLevel = intel + agil + strength + Random.Range(0, 5);
        
        int powerLevel = 0;
        

        return powerLevel;
    }



    void DetermineWinner(int playerOnePower, int playerTwoPowerLevel)
    {
        if(playerOnePowerLevel > playerTwoPowerLevel)
        {
            // playerm one has more power
            // deal a random amount of damage to the other player

            // check if other player has health left over, if not, tell us player one has won the game

        }
        else if(playerTwoPowerLevel > playerOnePowerLevel)
        {
            // player two has more power
            // deal a random amount of damage to the other player

            // check if other player has health left over, if not, tell us player two has won the game


        }
        else
        {
            // should we do anything if its a draw? maybe they both take damage
        }
    }

}
