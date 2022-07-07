using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Singleton
    private void Awake()
    {
        GameManagerScript[] gameManagers = FindObjectsOfType<GameManagerScript>();
        if (gameManagers.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
