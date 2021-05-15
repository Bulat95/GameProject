using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour, IGameManager
{
    public ManagerStatus managerStatus { get; private set; }

    public void Startup()
    {
        managerStatus = ManagerStatus.Started;
    }
}
