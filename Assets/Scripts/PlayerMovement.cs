using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed= 6.0f;

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-_speed*Time.deltaTime, 0f, 0f);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(_speed*Time.deltaTime,0f,  0f);
        }
        
    }
}
