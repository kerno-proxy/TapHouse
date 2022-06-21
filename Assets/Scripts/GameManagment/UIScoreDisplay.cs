using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;




public class UIScoreDisplay : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _scoreText;
    [SerializeField]
    PlayerBalance playerBalance;

    private void Awake()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();
        UpdateScoreText();
        
    }
    public void UpdateScoreText()
    {
        try
        {
            _scoreText.text = "Score: " + playerBalance.GetPlayerCurrentBalance().ToString();
        }
        catch (Exception e)
        {
            print("error");
            print(e.Message);
        }
    }
}
