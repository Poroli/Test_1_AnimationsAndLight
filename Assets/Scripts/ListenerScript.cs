using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerScript : MonoBehaviour
{
    // funktion die vom Speaker aufgerufen werden kann
    public static void Listen(string message)
    {
        print ("Message received: " + message);
    }
}
