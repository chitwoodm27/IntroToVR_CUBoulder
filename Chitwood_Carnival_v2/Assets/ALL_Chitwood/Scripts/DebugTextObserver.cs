using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DebugTextObserver : MonoBehaviour
{
    public float scoreValue;
    public TMP_Text scoreCount;
    // Called by Unity when this object is enabled in the scene
    void OnEnable() {
        // Attach the LogMessage function as a callback for the logMessageReceived event in Unity
        Application.logMessageReceived += LogMessage;
        
    }

    // Called by Unity when this object is disabled in the scene
    void OnDisable() {
        Application.logMessageReceived -= LogMessage;
    }

    public void LogMessage(string message, string stackTrace, LogType type) {
        // Set the text 
        GetComponent<TMP_Text>().SetText(message);
    }
}
