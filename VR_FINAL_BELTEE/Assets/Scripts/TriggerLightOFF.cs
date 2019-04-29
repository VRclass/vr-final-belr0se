using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLightOFF : MonoBehaviour
{
    public Light lightToSwitch = null;

    // When the trigger is entered 
    public void OnTriggerEnter(Collider other)
    {
        lightToSwitch.enabled = false; // turn the light off
        print("entered the OFF trigger");  // print the message
    }

}
