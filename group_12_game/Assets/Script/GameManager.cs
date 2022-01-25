using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int Day_Counter;
    PlayerControllsMain controlls;
    bool toggle;

    private void Awake()
    {
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        SceneManager.sceneLoaded -= LoadState;
        SceneManager.sceneLoaded += OnSceneLoaded;

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

    public void SaveState()
    {
        Debug.Log("Saved");

        string s = "";

        s += "0" + "|";
        s += Day_Counter.ToString() + "|";
        //s += playerXP.ToString() + "|";
        //s += weapon.weaponLevel.ToString();

        PlayerPrefs.SetString("SaveState", s);
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {
        //SceneManager.sceneLoaded -= LoadState;

        if (!PlayerPrefs.HasKey("SaveState"))
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        Day_Counter = int.Parse(data[1]);
        //playerXP = int.Parse(data[2]);
        //if (GetCurrentLevel() != 1)
            //player.SetLevel(GetCurrentLevel());

       // weapon.SetWeaponLevel(int.Parse(data[3]));
    }

}
