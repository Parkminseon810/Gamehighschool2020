﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Dungeon : MonoBehaviour
{
    public Rigidbody d_Rigidbody;
    public float d_Speed = 10f;
    // Update is called once per framep
    void Update()
    {
        //주석 : 설명 필요없는 스크립트를 임시적으로 비활성화하기 위해서 사용
        /* 주석 */
        Rigidbody rigidbody = /*gameObject.*/GetComponent<Rigidbody>();

        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 velocity = (new Vector3(xAxis, 0, yAxis) .normalized * d_Speed);
        //리지드 바디를 이용한 이동 처리
        d_Rigidbody.velocity = velocity;    


    }

   public void Die()
    {
        GameManager_Dungeon gameManager = FindObjectOfType<GameManager_Dungeon>();
        gameManager.ReturnTostartPoint();
    }
}