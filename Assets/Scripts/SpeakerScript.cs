using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerScript : MonoBehaviour
{
    [SerializeField] private string speakerMessage = "Secret";

    // funktion die mit einem Button aufgerufen wird dem Listener eine Message mitgibt 
    public void SpeakFunktion()
    {
        ListenerScript.Listen(speakerMessage);
    }
}

