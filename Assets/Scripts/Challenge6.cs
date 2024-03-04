using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Challenge6 : MonoBehaviour
{
    public float tempInFarenheit = 50;
    public float tempInCelcius = 0;
    public TextMeshProUGUI messageOutPut;


    // Start is called before the first frame update
    void Start()
    {
        StartConversion();
    }

    public void StartConversion()
    {
        tempInCelcius = ConvertFarenheitToCelcius(tempInFarenheit);
        PrintTemperatureMessage(tempInCelcius);
    }

    float ConvertFarenheitToCelcius(float temperatureInFarenheit)
    {
        Debug.Log(temperatureInFarenheit);
        tempInCelcius = temperatureInFarenheit;
        tempInCelcius = (tempInCelcius - 32) * 5 / 9;


        return tempInCelcius;
    }

    void PrintTemperatureMessage(float celcius)
    {
        if (tempInCelcius < 0)
        {
            Debug.Log("Freezing Weather!");
        }
        else if(tempInCelcius >= 0 && tempInCelcius < 10)
        {
            Debug.Log("Very Cold Weather!");
        }
        else if(tempInCelcius >= 10 &&  tempInCelcius < 20)
        {
            if(tempInCelcius < 13 || tempInCelcius == 14)
            {
                Debug.Log("Bit Cool Weather!");
            }
            else 
            {
                Debug.Log("Cold Weather!");
            }
        }
        else if(tempInCelcius >= 20 &&  tempInCelcius < 30)
        {
            Debug.Log("Normal Weather!");
        }
        else if( tempInCelcius >= 30 && tempInCelcius < 40)
        {
            if (tempInCelcius < 35)
            {
                Debug.Log("Nice Qld Weather!");
            }
            else if(tempInCelcius < 37 &&  tempInCelcius > 35)
            {
                Debug.Log("Weather's Getting Warmer!");
            }
            else
            {
                Debug.Log("Hot Weather!");
            }
        }
        else if(tempInCelcius >= 40)
        {
            Debug.Log("Very Hot Weather!");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
