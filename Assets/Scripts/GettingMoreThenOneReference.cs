using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingMoreThenOneReference : MonoBehaviour
{
    public List<Collider> allColliders = new List<Collider>();

    public Collider[] allCollidersFound;

    // Start is called before the first frame update
    void Start()
    {

        allCollidersFound = FindObjectsOfType<Collider>();

        for (int i = 0; i < allCollidersFound.Length; i++)
        {
            Debug.Log(allCollidersFound[i].name);
        }

        // this adds all the colliders found to my list 
        allColliders.AddRange(allCollidersFound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
