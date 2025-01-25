using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager m_instance;

    public PlayerHealthController playerHealth { get; private set; }

    public static GameManager instance => m_instance;

    private void Awake()
    {
        if (m_instance == null)
        {
            m_instance = this;
        }

        playerHealth = GetComponentInChildren<PlayerHealthController>();
    }
}