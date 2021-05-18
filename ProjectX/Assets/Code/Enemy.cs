using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : GameCharacter
{
    private NavMeshAgent agent;
    public override int Health { get; set; }

    public override void MovementLogic()
    {
        
    }
    private void Update()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(GameObject.Find("Player").transform.position);
    }
}
