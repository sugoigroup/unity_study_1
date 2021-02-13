using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharactor : MonoBehaviour
{
    public float speed;
    private Joypad joypad;

    // Awake는 무조건 실행되는 스크립트이다. start는 스크립트가 활성화 상태에서만 실행된다. 
    private void Awake()
    {
        joypad = GameObject.FindObjectOfType<Joypad>();
    }

    private void FixedUpdate()
    {
        if (joypad.Horizontal != 0 || joypad.Vertical != 0)
        {
            MoveControl();
        }
    }

    private void MoveControl()
    {

        Vector3 upMovement = Vector3.up * speed *  Time.deltaTime*  joypad.Vertical; 
        Vector3 rightMovement = Vector3.right * speed * Time.deltaTime  *  joypad.Horizontal;
        transform.position += upMovement;
        transform.position += rightMovement;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
