using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovementUpdatedScript : MonoBehaviour
{
    PlayerControllsMain controlls;
    CharacterController C_controller;
    bool can_move_forward;
    bool can_move_left;
    bool can_move_right;
    bool can_move_back;
    public int speed = 1;

    void Awake()
    {
        controlls = new PlayerControllsMain();
        controlls.GamePlay.ForwardMovement.performed += con => MoveForward();
        controlls.GamePlay.LeftMovement.performed += con => MoveLeft();
        controlls.GamePlay.RightMovement.performed += con => MoveRight();
        controlls.GamePlay.BackMovement.performed += con => MoveBack();
        controlls.GamePlay.ForwardMovement.canceled += con => DontMoveForward();
        controlls.GamePlay.LeftMovement.canceled += con => DontMoveLeft();
        controlls.GamePlay.RightMovement.canceled += con => DontMoveRight();
        controlls.GamePlay.BackMovement.canceled += con => DontMoveBack();
        C_controller = this.GetComponent<CharacterController>();
    }

    private void Update()
    {
        if(can_move_forward == true)
        {
            Vector3 alsoMove = transform.forward * speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }

        if (can_move_left == true)
        {
            Vector3 alsoMove = transform.right * - speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }

        if (can_move_right == true)
        {
            Vector3 alsoMove = transform.right * speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }

        if (can_move_back == true)
        {
            Vector3 alsoMove = transform.forward * - speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }
    }
    
    void MoveForward()
    {
        Debug.Log("move forward");
        can_move_forward = true;
    }

    void DontMoveForward()
    {
        Debug.Log("mstop walking");
        can_move_forward = false;
    }

    void MoveLeft()
    {
        Debug.Log("moving left");
        can_move_left = true;
    }

    void DontMoveLeft()
    {
        Debug.Log("mstop walking");
        can_move_left = false;
    }

    void MoveRight()
    {
        Debug.Log("moving right");
        can_move_right = true;
    }

    void DontMoveRight()
    {
        Debug.Log("mstop walking");
        can_move_right = false;
    }

    void MoveBack()
    {
        Debug.Log("moving back");
        can_move_back = true;
    }

    void DontMoveBack()
    {
        Debug.Log("mstop walking");
        can_move_back = false;
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
