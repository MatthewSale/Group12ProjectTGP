using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // variables for game manager functions
    public static GameManager instance;
    public int Day_Counter;
    PlayerControllsMain controlls;
    bool toggle;    

    //variables for player    
    GameObject player;

    // variables for camra fade    
    public Image cover;
    public float alpha;
    public bool AI_can_move = true;

    private void Awake()   
    {
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        SceneManager.sceneLoaded -= LoadState;
       // SceneManager.sceneLoaded += OnSceneLoaded;

        controlls = new PlayerControllsMain();
    }

    private void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Screen");
        cover = temp.GetComponent<Image>();
    }

    private void Update()
    {
        controlls.GamePlay.SleepFunction.performed += con => Increse_Counter_By_One();
        controlls.GamePlay.SleepFunction.canceled += con => Toggle_Checker();
        cover.color = new Color(0f, 0f, 0f, alpha);
    }

    public void Increse_Counter_By_One()
    {
        if (toggle == false)
        {          
            StartCoroutine(delay());            
            toggle = true;            
            AI_can_move = false;
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
        player = GameObject.FindGameObjectWithTag("Harry");
        PlayerMovementUpdatedScript P_M_S = player.GetComponent<PlayerMovementUpdatedScript>();
        Player_health_script P_H_S = player.GetComponent<Player_health_script>();
        s += P_M_S.sprint_meater.ToString() + "|";
        s += P_M_S.light_meate.ToString() + "|";
        s += P_H_S.Player_health.ToString() + "|";
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
        player = GameObject.FindGameObjectWithTag("Harry");
        PlayerMovementUpdatedScript P_M_S = player.GetComponent<PlayerMovementUpdatedScript>();
        Player_health_script P_H_S = player.GetComponent<Player_health_script>();
        P_H_S.Player_health = int.Parse(data[4]);
        P_M_S.light_meate = float.Parse(data[3]);
        P_M_S.sprint_meater = float.Parse(data[2]);
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.001f);
        alpha = alpha + 0.001f;

        if (alpha <= 1)
        {
            StartCoroutine(delay());
        }
        else
        {
            StartCoroutine(delay1());
        }
    }
    IEnumerator delay1()
    {
        yield return new WaitForSeconds(2f);
        StartCoroutine(delay2());
        player = GameObject.FindGameObjectWithTag("Harry");
        PlayerMovementUpdatedScript P_M_S = player.GetComponent<PlayerMovementUpdatedScript>();
        Player_health_script P_H_S = player.GetComponent<Player_health_script>();
        Day_Counter = Day_Counter + 1;
        
        P_M_S.sprint_meater = 100;
        P_M_S.light_meate = 100;
        P_H_S.Player_health = 100;
    }
    IEnumerator delay2()
    {
        yield return new WaitForSeconds(0.02f);
        alpha = alpha - 0.01f;
        if (alpha >= 0)
        {
            StartCoroutine(delay2());
            AI_can_move = true;
        }
    }
}
