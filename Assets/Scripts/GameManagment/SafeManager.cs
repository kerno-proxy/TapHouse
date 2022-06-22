using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeManager : MonoBehaviour
{
    [SerializeField]
    int _currentSafeCapacity = 0;
    [SerializeField]
    int _currentSafeValue = 0;
    [SerializeField]
    int _addValue = 0;
    [SerializeField]
    float _safeFillUpFrequencyInSeconds = 0f;
    [SerializeField]
    int _safeNextUpgradeCost = 0;

    private void Start()
    {
        
        InvokeRepeating("AddToSafe", 2.0f, _safeFillUpFrequencyInSeconds);
    }
    //This method can be used to increase value in other cases (like bonus increase from advertisement or something)
    private void AddToSafe(int value)
    {
        if (_currentSafeValue+value < _currentSafeCapacity)
        {
            _currentSafeValue += value;
        }
        else
        {
            _currentSafeValue = _currentSafeCapacity;
            print("Safe capacity reached");
        }

    }
    //This method is only for InvokeRepeating.
    private void AddToSafe()
    {
        if (_currentSafeValue + _addValue < _currentSafeCapacity)
        {
            _currentSafeValue += _addValue;
        }
        else
        {
            _currentSafeValue = _currentSafeCapacity;
            print("Safe capacity reached");
        }
       
    }

}
