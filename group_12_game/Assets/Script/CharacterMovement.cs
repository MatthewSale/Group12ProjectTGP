using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public float speed = .1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Information on movement displayed in console
        float HorizontalValue = Input.GetAxis("Horizontal");
        float VerticalValue = Input.GetAxis("Vertical");
        
        if (HorizontalValue != 0)
        {
            print("Horizontal Movement: " + HorizontalValue);
        }

        if (VerticalValue != 0)
        {
            print("Verticle Movement: " + VerticalValue);
        }
        Vector3 Movement = new Vector3(HorizontalValue, 0.0f, VerticalValue);
        
        transform.position += Movement * speed;



    }
}
