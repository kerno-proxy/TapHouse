using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBalance : MonoBehaviour
{

    [SerializeField]
    int _playerCurrentBalance = 0;
    [SerializeField]
    int _playerCurrentGems = 0;
    [SerializeField]
    int _tapValue = 0;
        
    public void PlayerCurrencyIncrease()
    {
        _playerCurrentBalance += _tapValue;
    }
    public void PlayerCurrencyIncrease(int value)
    {
        _playerCurrentBalance += value;
    }

    public int GetPlayerCurrentBalance()
    {
        return _playerCurrentBalance;
    }
}
