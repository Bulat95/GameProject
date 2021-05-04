using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour, IGameManager
{
    public ManagerStatus managerStatus { get; private set; }

    public int Health { get; private set; }
    public int MaxHealth { get; private set; }

    public void Startup()
    {
        Debug.Log("Player manager started");
        Health = 50;
        MaxHealth = 100;

        managerStatus = ManagerStatus.Started;
    }

    public void ChangeHealth(int value)
    {
        Health += value;
        if (Health > MaxHealth)
            Health = MaxHealth;
        else if (Health < 0)
            Health = 0;

        Debug.Log("Health: " + Health + "/" + MaxHealth);
    }
}
