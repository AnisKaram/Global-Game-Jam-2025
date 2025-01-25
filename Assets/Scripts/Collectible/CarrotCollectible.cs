using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotCollectible : MonoBehaviour, ICollectible
{
    public void Collect()
    {
        // Increment Carrot amount
        // Destroy
        // Play SFX
        // Play Particle Effect
        Debug.Log($"Carrot Collected");
    }
}
