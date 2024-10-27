using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public static GameDataManager Instance;
    
    public string PlayerName;
    public int BestScore = 0;
    public string BestPlayerName;

    private void Awake()
    {
        // Singleton pattern setup
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}