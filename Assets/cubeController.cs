using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Scripting.APIUpdating;

public class cubeController : MonoBehaviour
{
    public float speed = 5f;
    //public float gavityScale ;
    public float jumpSpeed = 10f;
    public float jumpCoolDown = 0f;
    void Update() {
        Rigidbody body = GetComponent<Rigidbody>();
        //body.velocity = Vector3.up * 1.2f;
        Vector3 move = new Vector3();
        move.x =speed * Input.GetAxis("Horizontal");
        move.z =speed * Input.GetAxis("Vertical");
        move.y =body.velocity.y;
        //move.y =Physics.gravity.y *Time.deltaTime * gavityScale ;

/*
        if(Input.GetKeyDown(KeyCode.Space)){
            move.y = jumpSpeed;
        }
*/
        jumpCoolDown = jumpCoolDown - Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) && jumpCoolDown <= 0 ){
            jumpCoolDown = 1.5f ;
            move.y = jumpSpeed;
        }

        body.velocity = move;
    }
 }
