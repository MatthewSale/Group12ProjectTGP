using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovementUpdatedScript : MonoBehaviour
{
    // controlls variable
    PlayerControllsMain controlls;

    //movment varibales
    CharacterController C_controller;
    bool can_move_forward;
    bool can_move_left;
    bool can_move_right;
    bool can_move_back;
    public bool Is_moving;

    // camera variables
    float Camera_rotation = 0f;
    Vector2 rotate;
    public Transform camera;
    public Transform Player_modle;

    //player speed variabels
    public int speed;
    public float sprint_meater = 100;
    public bool toggle = true;

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
        controlls.GamePlay.Sprint.performed += con => Sprint();
        controlls.GamePlay.Sprint.canceled += con => SprintStop();

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
        Camera_rotation -= (pitch / 2);
        Camera_rotation = Mathf.Clamp(Camera_rotation, -90f, 90f);
        camera.localRotation = Quaternion.Euler(Camera_rotation, 0f, 0f);
        Player_modle.Rotate(Vector3.up * yar);        
    }
    
    void MoveForward()
    {
        Debug.Log("move forward");
        can_move_forward = true;
        Is_moving = true;
    }

    void DontMoveForward()
    {
        Debug.Log("mstop walking");
        can_move_forward = false;
        Is_moving = false;
    }

    void MoveLeft()
    {
        Debug.Log("moving left");
        can_move_left = true;
        Is_moving = true;
    }

    void DontMoveLeft()
    {
        Debug.Log("mstop walking");
        can_move_left = false;
        Is_moving = false;
    }

    void MoveRight()
    {
        Debug.Log("moving right");
        can_move_right = true;
        Is_moving = true;
    }

    void DontMoveRight()
    {
        Debug.Log("mstop walking");
        can_move_right = false;
        Is_moving = false;
    }

    void MoveBack()
    {
        Debug.Log("moving back");
        can_move_back = true;
        Is_moving = true;
    }

    void DontMoveBack()
    {
        Debug.Log("mstop walking");
        can_move_back = false;
        Is_moving = false;
    }

    void Sprint()
    {
        if(toggle == true)
        {
            StartCoroutine(delay());
            toggle = false;
        }

        if (sprint_meater >= 0)
        {
            speed = 12;
        }
    }

    void SprintStop()
    {
        toggle = true;
        speed = 5;
    }

    private void OnEnable()
    {
       controlls.GamePlay.Enable();
    }

    private void OnDisable()
    {
       controlls.GamePlay.Disable();
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.0001f);
        sprint_meater = sprint_meater - 0.01f;
        if(toggle == false)
        {
            StartCoroutine(delay());
        }
    }
}
