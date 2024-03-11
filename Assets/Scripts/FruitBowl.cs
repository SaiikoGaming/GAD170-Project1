using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBole : MonoBehaviour
{

    public Fruit[] allFruit = new Fruit[] { };
    public char[] myName = new char[] { 'T', 'Y', 'L', 'O', 'R'};

    // Start is called before the first frame update
    void Start()
    {
        // this will give me the first elements name
        Debug.Log("the first fruit is: " + allFruit[0].fruitName);

        Debug.Log(allFruit.Length);
        // acces the last element of an array
        Debug.Log("the last fruit is: " + allFruit[allFruit.Length - 1].fruitName);

        //access a random element of an array
        Debug.Log("A random fruit is: " + allFruit[Random.Range(0, allFruit.Length)].fruitName);

        // remove the L from name 
        myName = new char[] { 'T', 'Y', 'O', 'R' };
        // add the L back in
        myName = new char[] { 'T', 'Y', 'L', 'O', 'R' };

        // print all names of fruit
        for(int i = 0; i < allFruit.Length; i++)
        {
            Debug.Log("The fruit name is: " + allFruit[i].fruitName);
        }

        for (int i = allFruit.Length - 1; i >= 0; i--)
        {
            Debug.Log("The fruit name is: " + allFruit[i].fruitName);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
