using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandelerScript : MonoBehaviour
{
    Animator player;
    GameObject Game_Player;
    bool is_moving;

    private void Start()
    {
        player = this.GetComponent<Animator>();
        Game_Player = GameObject.FindGameObjectWithTag("Harry");
    }
    private void Update()
    {
        PlayerMovementUpdatedScript G_M = Game_Player.GetComponent<PlayerMovementUpdatedScript>();
        is_moving = G_M.Is_moving;

        if(is_moving == true)
        {
            player.SetBool("Is_walking", true);
        }
        else
        {
            player.SetBool("Is_walking", false);
        }
    }
}
