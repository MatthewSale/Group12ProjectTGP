using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovmentUpdatedScript : MonoBehaviour
{
    PlayerControllsMain controlls;
    CharacterController C_controller;
    bool can_move_foward;
    void Awake()
    {
        controlls = new PlayerControllsMain();
        controlls.GamePlay.FowardMovment.performed += con => MoveFoward();
        controlls.GamePlay.FowardMovment.canceled += con => DontMoveFoward();
        C_controller = this.GetComponent<CharacterController>();
    }

    private void Update()
    {
        if(can_move_foward == true)
        {
            Vector3 alsoMove = transform.forward * 1;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }
    }

    void MoveFoward()
    {
        Debug.Log("move");
        can_move_foward = true;
    }
    void DontMoveFoward()
    {
        Debug.Log("mstop walking");
        can_move_foward = false;
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
