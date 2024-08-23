using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LightChange : MonoBehaviour
{
    public Material light;

    // When trigger is entered, material emission is turned on, making lights look like they light up when you approach
    void OnTriggerEnter(Collider other)
    {
            light.EnableKeyword("_EMISSION");
            // debug print("ENTER");
    }

    void OnTriggerExit(Collider other)
    {
            light.DisableKeyword("_EMISSION");
            // debug print("EXIT");
    }
}
