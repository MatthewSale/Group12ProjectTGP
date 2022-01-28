using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
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
    int Camera_Sensitivity = 3;

    //player speed variabels
    public int speed;
    public float sprint_meater = 100;
    public bool toggle = true;

    //ui variables
    public Slider slider;
    public Slider Light_slider;

    //light variables
    public GameObject Light;
    bool Light_Toggle = true;
    bool Light_meater_toggle;
    public float light_meate = 100;
    bool Light_can_turn_on = true;

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
        controlls.GamePlay.MovmentChecker.performed += con => Moving();
        controlls.GamePlay.MovmentChecker.canceled += con => Not_Moving();
        controlls.GamePlay.LightToggleFunction.performed += con => ToggleLight();
        controlls.GamePlay.LightToggleFunction.canceled += con => ToggleLightChecker();

        C_controller = this.GetComponent<CharacterController>();
    }

    private void Update()
    {
        slider.value = sprint_meater;
        Light_slider.value = light_meate;
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

        if (sprint_meater <= 0)
        {
            speed = 5;
        }

        if(light_meate <= 0)
        {
            Light_can_turn_on = false;
            Light.SetActive(false);
        }
        else
        {
            Light_can_turn_on = true;
        }

        float yar = rotate.x;
        float pitch = rotate.y;
        Camera_rotation -= (pitch / Camera_Sensitivity);
        Camera_rotation = Mathf.Clamp(Camera_rotation, -90f, 90f);
        camera.localRotation = Quaternion.Euler(Camera_rotation, 0f, 0f);
        Player_modle.Rotate(Vector3.up * (yar/Camera_Sensitivity));        

        if(Light.activeInHierarchy)
        {
            Light_meater_toggle = true;
            StartCoroutine(delay1());
        }
        else
        {
            Light_meater_toggle = false;
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

    void Moving()
    {
        Is_moving = true;
    }
    void Not_Moving()
    {
        Is_moving = false;
    }

    void ToggleLight()
    {
        if (Light_can_turn_on == true)
        {
            if (Light_Toggle == true)
            {
                if (Light.activeInHierarchy)
                {
                    Light.SetActive(false);
                    Light_Toggle = false;
                }
                else
                {
                    Light.SetActive(true);
                    Light_Toggle = false;
                }
            }
        }
    }
    void ToggleLightChecker()
    {
        Light_Toggle = true;
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
    IEnumerator delay1()
    {
        yield return new WaitForSeconds(0.0001f);
        light_meate = light_meate - 0.000007f;
        if (Light_meater_toggle == true)
        {
            StartCoroutine(delay1());
        }
    }
}
