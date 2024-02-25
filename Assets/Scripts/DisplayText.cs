using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // this access text mesh pro library

public class DisplayText : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = Random.Range(0, 100);
        // access the reference to my piece of text and access the string and update it
        scoreText.text = "My Score Is: " + currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
