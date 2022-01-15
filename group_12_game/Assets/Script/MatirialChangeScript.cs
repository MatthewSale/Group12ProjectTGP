using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatirialChangeScript : MonoBehaviour
{
    public Material Day_One_Matirial;
    public Material Day_Two_Matirial;
    public Material Day_Three_Matirial;
    public Material Day_four_Matirial;
    public Material Day_five_Matirial;

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

        if (Current_Day == 1)
        {
            this.GetComponent<MeshRenderer>().material = Day_One_Matirial;
        }
        if(Current_Day == 2)
        {
            this.GetComponent<MeshRenderer>().material = Day_Two_Matirial;
        }
        if (Current_Day == 3)
        {
            this.GetComponent<MeshRenderer>().material = Day_Three_Matirial;
        }
        if (Current_Day == 4)
        {
            this.GetComponent<MeshRenderer>().material = Day_four_Matirial;
        }
        if (Current_Day == 5)
        {
            this.GetComponent<MeshRenderer>().material = Day_five_Matirial;
        }
    }
}
