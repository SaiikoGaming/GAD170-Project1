using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingReferences : MonoBehaviour
{
    public Player playerReference;

    // Start is called before the first frame update
    void Start()
    {
        playerReference = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
