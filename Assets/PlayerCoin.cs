using System;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{
    private int collectedCoins;

    public event Action<int> OnCoinAdd;

    public event Action<int> OnCoinInit;

    public void AddCoin(int cointToAdd)
    {
        collectedCoins += cointToAdd;
        OnCoinAdd?.Invoke(collectedCoins);
    }

    private void Start()
    {
        OnCoinInit?.Invoke(collectedCoins);
    }

   
}
