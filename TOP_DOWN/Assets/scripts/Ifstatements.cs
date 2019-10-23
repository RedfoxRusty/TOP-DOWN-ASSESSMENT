using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifstatements : MonoBehaviour
{
    public float coffeeTemp = 170.0f;
    float hotLimit = 180.0f;
    float coldLimit = 110.0f;

    // Update is called once per frame
    void Update()
    {
        coffeeTemp -= Time.deltaTime * 5;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
    }

    void TemperatureTest()
    {
        if(coffeeTemp > hotLimit)
        {
            Debug.Log("Too hot!");
        }
        else if (coffeeTemp < coldLimit)
        {
            Debug.Log("Too cold!");
        }
        else
        {
            Debug.Log("meh, it's bearable");
        }
    }
}
