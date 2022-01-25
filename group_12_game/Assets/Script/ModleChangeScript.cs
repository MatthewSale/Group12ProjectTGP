using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModleChangeScript : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;

    GameObject Game_Manager;
    int Current_Day;
    private void Start()
    {
        Game_Manager = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void Update()
    {
        GameManager G_M = Game_Manager.GetComponent<GameManager>();
        Current_Day = G_M.Day_Counter;

        if(Current_Day == 1)
        {
            one.SetActive(true);
        }
        else
        {
            one.SetActive(false);
        }

        if (Current_Day == 2)
        {
            two.SetActive(true);
        }
        else
        {
            two.SetActive(false);
        }

        if (Current_Day == 3)
        {
            three.SetActive(true);
        }
        else
        {
            three.SetActive(false);
        }

        if (Current_Day == 4)
        {
            four.SetActive(true);
        }
        else
        {
            four.SetActive(false);
        }

        if (Current_Day == 5)
        {
            five.SetActive(true);
        }
        else
        {
            five.SetActive(false);
        }
    }
}
