﻿using UnityEngine;

public class BubbleCollision : MonoBehaviour
{
    void OnParticleCollision(GameObject other)
    {
        // Eğer çarpılan obje "Destructible" tagine sahipse yok et
        if (other.CompareTag("Destructible"))
        {
            Destroy(other);
        }
    }
}