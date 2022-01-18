using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioDayScript : MonoBehaviour
{
    public AudioClip Day_One_Audio;
    public AudioClip Day_Two_Audio;
    public AudioClip Day_Three_Audio;
    public AudioClip Day_four_Audio;
    public AudioClip Day_five_Audio;
    public AudioSource clip;
    bool toggle = true;
    int temp = 2;

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
            
        if (temp == Current_Day)
        {
            toggle = true;
            temp = temp + 1;

        }

            if (Current_Day == 1)
            {
            
            this.GetComponent<AudioSource>().clip = Day_One_Audio;

                if (toggle == true)
                {
                
                    clip.Play();
                    
                    toggle = false;
                }

            }

            if (Current_Day == 2)
            {
                
             this.GetComponent<AudioSource>().clip = Day_Two_Audio;

                if (toggle == true)
                {
                     
                clip.Play();

                toggle = false;
                }

            }

            if (Current_Day == 3)
            {
            
            this.GetComponent<AudioSource>().clip = Day_Three_Audio;

                if (toggle == true)
                {
                
                clip.Play();

                toggle = false;
                }
            }

            if (Current_Day == 4)
            {
           
            this.GetComponent<AudioSource>().clip = Day_four_Audio;

                if (toggle == true)
                {

                clip.Play();

                toggle = false;
                }
            }

            if (Current_Day == 5)
            {

            this.GetComponent<AudioSource>().clip = Day_five_Audio;

                if (toggle == true)
                {

                clip.Play();

                toggle = false;
                }
            }
        
    }
}
