using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameCharacter
{
    private PlayerMove playerMove;
    private int _health;
    public override int Health { get => _health; set => _health = value; }
    private void Awake()
    {
        gameObject.AddComponent<PlayerMove>();
    }
    private void Start()
    {
        playerMove.SpeedMove = 10.0f;
        playerMove.JumpPower = 8.0f;
    }
    private void Update()
    {
        MovementLogic();
    }

    public override void MovementLogic()
    {

        playerMove.CharacterMove();
        playerMove.GamingGravity();
    }
}
