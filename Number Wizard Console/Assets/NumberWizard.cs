using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var max = 1000;
        var min = 1;
        Debug.Log("Welcome to number wizard.");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log($"Highest number you  can pick is: {max}");
        Debug.Log($"Lowest number you can pick is: {min}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
