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

    // camra variables
    float Camra_rotation = 0f;
    Vector2 rotate;
    public Transform camra;
    public Transform Player_modle;

    //default player speed
    public int speed = 6;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        
        controlls = new PlayerControllsMain();
        controlls.GamePlay.rotate.performed += context => rotate = context.ReadValue<Vector2>();
        controlls.GamePlay.rotate.canceled += context => rotate = Vector2.zero;
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
        //Forward Movement
        if(can_move_forward == true)
        {
            Vector3 alsoMove = transform.forward * speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }
        //Left movement
        if (can_move_left == true)
        {
            Vector3 alsoMove = transform.right * - speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }
        //Right movement
        if (can_move_right == true)
        {
            Vector3 alsoMove = transform.right * speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }
        //back movement
        if (can_move_back == true)
        {
            Vector3 alsoMove = transform.forward * - speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }

        float yar = rotate.x;
        float pitch = rotate.y;
        Camra_rotation -= (pitch / 2);
        Camra_rotation = Mathf.Clamp(Camra_rotation, -90f, 90f);
        camra.localRotation = Quaternion.Euler(Camra_rotation, 0f, 0f);
        Player_modle.Rotate(Vector3.up * yar);
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
