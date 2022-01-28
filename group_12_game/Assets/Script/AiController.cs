using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AiController : MonoBehaviour
{
    NavMeshAgent AI;
    Transform goal1;
    GameObject Game_Manager;
    int Current_Day;

    private void Start()
    {
        Game_Manager = GameObject.FindGameObjectWithTag("GameManager");  
        AI = this.GetComponent<NavMeshAgent>();
        goal1 = GameObject.FindGameObjectWithTag("Harry").transform;        
        
    }
    void Update()
    {
        GameManager G_M = Game_Manager.GetComponent<GameManager>();
        Current_Day = G_M.Day_Counter;
        if (G_M.AI_can_move == true)
        {
            AI.speed = Current_Day * 2 - 2;
        }
        else
        {
            AI.speed = 0;
        }
        AI.destination = goal1.position;
    }
}
