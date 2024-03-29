using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turningobjectsonandoff : MonoBehaviour
{
    public List<GameObject> allShapes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < allShapes.Count; i++)
        {
            allShapes[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < allShapes.Count; i++)
            {
                allShapes[i].SetActive(true);
            }
            for (int i = 0;i < allShapes.Count; i++)
            {

            }
        }
    }
}
