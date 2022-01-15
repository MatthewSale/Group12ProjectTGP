using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Day_Counter;
    PlayerControllsMain controlls;
    bool toggle;

    private void Awake()
    {
        controlls = new PlayerControllsMain();
    }

    private void Update()
    {
        controlls.GamePlay.SleepFunction.performed += con => Increse_Counter_By_One();
        controlls.GamePlay.SleepFunction.canceled += con => Toggle_Checker();
    }

    public void Increse_Counter_By_One()
    {
        if (toggle == false)
        {
            Day_Counter = Day_Counter + 1;
            toggle = true;
        }
    }

    public void Toggle_Checker()
    {
        toggle = false;
    }

    private void OnEnable()
    {
        controlls.GamePlay.Enable();
    }

    private void OnDisable()
    {
        controlls.GamePlay.Disable();
    }
}
