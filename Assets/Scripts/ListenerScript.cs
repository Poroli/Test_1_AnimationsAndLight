using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerScript : MonoBehaviour
{
    public static void Listen(string message)
    {
        print ("Message received: " + message);
    }
}
