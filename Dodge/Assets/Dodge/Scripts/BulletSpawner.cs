﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform m_playerTransform;

    public GameObject m_Bullet;


    public float m_AttackInterval= 1f;
    public float  m_AttackCooltime= 0f;
    public float m_RotationSpeed = 60f;

    // Update is called once per frame
    void Update()
    {
        //공격 쿨타임 계산
        m_AttackCooltime += Time.deltaTime;

        if(m_AttackCooltime >= m_AttackInterval)
        {
            //총알 생성
        GameObject bullet = GameObject.Instantiate(m_Bullet);
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;

            var b = bullet.GetComponent<Bullet>();
            b.m_Velocity = transform.forward;

            //쿨타임 초기화 
            m_AttackCooltime = 0;
        }

        //GameObject.Find("player"); //게임오브젝트의 이름
        GameObject player = GameObject. FindGameObjectWithTag("Player"); //Player
        //GameObject.FindGameObjectWithTag<PlayerController>();

       // GameObject,FindGameobjetsWithTag("Player"); // 모든 player
       // GameObject, FindobjectdlofType<PlayerController>(); //모든 PlayerController 검색

        //transform.Rotate(0, m_RotationSpeed * Time.deitaTime,0);
        if(player != null)
        {
            Vector3 attacketPoint = player.transform.position;
            attacketPoint.y = transform.position.y;
            transform.LookAt(attacketPoint);

        }
        

    }
}
