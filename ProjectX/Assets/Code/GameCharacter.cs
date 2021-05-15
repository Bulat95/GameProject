using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameCharacter : MonoBehaviour, ITakeDamage
{
    public abstract int Health { get; set; }

    public void Death()
    {
        if (Health <= 0)
            Destroy(gameObject);
    }

    public abstract void MovementLogic();
}
