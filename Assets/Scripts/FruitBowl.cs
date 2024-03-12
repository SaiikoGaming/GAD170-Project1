using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBole : MonoBehaviour
{

    public Fruit[] allFruit = new Fruit[] { };

    public List<Fruit> allFruitList = new List<Fruit>();

    public char[] myName = new char[] {'T', 'Y', 'L', 'O', 'R'};

    public List<char> myListName = new List<char>() { 'T', 'Y', 'L', 'O', 'R' };

    // Start is called before the first frame update
    void Start()
    {
        // this will give me the first elements name
        Debug.Log("the first fruit is: " + allFruit[0].fruitName);
        Debug.Log("the first fruit is: " + allFruitList[0].fruitName);

        Debug.Log(allFruit.Length);
        Debug.Log(allFruitList.Count);
        // acces the last element of an array
        Debug.Log("the last fruit is: " + allFruit[allFruit.Length - 1].fruitName);
        Debug.Log("the first fruit is " + allFruitList[allFruitList.Count - 1].fruitName);

        //access a random element of an array
        Debug.Log("A random fruit is: " + allFruit[Random.Range(0, allFruit.Length)].fruitName);
        // random element from a list 
        Debug.Log("a random fruit is: " + allFruitList[Random.Range(0, allFruitList.Count)].fruitName);


        // remove the L from name 
        myName = new char[] { 'T', 'Y', 'O', 'R' };

        // myListName.Remove('T'); // this removes the first 'T' in my list 
        myListName.RemoveAt(1); // this removes the element at this index 

        // myListName.Add('t'); // this will add a t to the last element of our list 
        myListName.Insert(1, 'Y'); // this adds a t at element 2
        // myListName.Clear(); // this will empty our list
        // add the L back in
        myName = new char[] { 'T', 'Y', 'L', 'O', 'R' };

        // print all names of fruit
        for(int i = 0; i < allFruit.Length; i++)
        {
            Debug.Log("The fruit name is: " + allFruit[i].fruitName);
        }

        for (int i=0; i < allFruitList.Count; i++)
        {
            Debug.Log("the fruit name is: " + allFruitList[i].fruitName);
        }


        for (int i = allFruit.Length - 1; i >= 0; i--)
        {
            Debug.Log("The fruit name is: " + allFruit[i].fruitName);
        }

        for (int i = allFruitList.Count - 1; i >= 0; i--)
        {
            Debug.Log("The fruit name is: " + allFruitList[i].fruitName);
        }

        //for each loop does the same as for int i, except it only works on collections of objects and
        // typically does that set of instructions on each.
        foreach(Fruit fruit in allFruitList)
        {
            
            Debug.Log("The fruit name is: " + fruit.name);
        }

        foreach(char c in myListName)
        {
            Debug.Log(c);
        }

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
