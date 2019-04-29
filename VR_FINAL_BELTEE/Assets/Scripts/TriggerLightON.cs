using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLightON : MonoBehaviour
{
    public Light lightToSwitch = null;

    // When the trigger is entered 
    public void OnTriggerEnter(Collider other)
    {
        lightToSwitch.enabled = true; // turn the light off
        print("entered the ON trigger");  // print the message
    }

}
