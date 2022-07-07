using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBalance : MonoBehaviour
{

    [SerializeField]
    int _playerCurrentBalance = 0;
    [SerializeField]
    int _playerCurrentGems = 0;
    [SerializeField]
    int _tapValue = 0;
    [SerializeField]
    SafeManager safeManager;
    [SerializeField]
    TextMeshProUGUI coinsValue;

    private void Awake()
    {
        safeManager = GetComponent<SafeManager>();
        coinsValue = GameObject.Find("CoinsValue").GetComponent<TextMeshProUGUI>();
    }
   
    public void PlayerCurrencyIncrease()
    {
        _playerCurrentBalance += _tapValue; 
        UpdatePlayerCoinsValue();
    }
    public void PlayerCurrencyIncrease(int value)
    {
        _playerCurrentBalance += value;
       
    }

    public int GetPlayerCurrentBalance()
    {
        return _playerCurrentBalance;
    }
    public void EmptySafe()
    {
        _playerCurrentBalance += safeManager.GetSafeCurrentValue();
        UpdatePlayerCoinsValue();
        safeManager.ResetSafe();
        
        
    }
    private void UpdatePlayerCoinsValue()
    {
        coinsValue.text = "Coins: " + _playerCurrentBalance.ToString();
    }
}
