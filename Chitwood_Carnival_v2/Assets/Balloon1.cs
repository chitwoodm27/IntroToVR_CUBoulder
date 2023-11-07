using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon1 : MonoBehaviour
{
    public ParticleSystem destructionEffect; // Reference to the Particle System.

    void Start()
    {
        // Ensure the destruction effect is initially deactivated.
        if (destructionEffect != null)
        {
            destructionEffect.Stop();
        }
    }

    void DestroyObject()
    {
        // Check if a destruction effect exists and activate it.
        if (destructionEffect != null)
        {
            destructionEffect.Play();
        }

    }
}
