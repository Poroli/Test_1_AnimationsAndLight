using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerScript : MonoBehaviour
{
    [SerializeField] private string speakerMessage = "Secret";
    public void SpeakFunktion()
    {
        ListenerScript.Listen(speakerMessage);
    }
}

