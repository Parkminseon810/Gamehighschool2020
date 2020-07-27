using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float m_Speed = 1f;

    public Bullet m_BulletPrefab;
    public float m_AttackDelay = 0.5f;
    public float m_AttackCooldown = 0f;

    public Transform[] m_FireMuzzles;
    
    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 velocity = (new Vector3(xAxis, yAxis, 0).normalized * m_Speed);

        Vector3 movement = velocity * Time.deltaTime;
        transform.position = transform.position + movement;

        //총알 발사
        //GameObject.Instantiate
        if(Input.GetKey(KeyCode.Space)&& m_AttackCooldown <= 0)
        {
            //총알생성
            foreach (var fireMuzzle in m_FireMuzzles)
            {
                var bullet = GameObject.Instantiate(m_BulletPrefab,
                    fireMuzzle.position, fireMuzzle.rotation);

            }
            m_AttackCooldown = m_AttackDelay;
        }
        m_AttackCooldown -= Time.deltaTime;
    }
    


    public void Die()
    {
        GameManager.instance.OnPlayerDie();
        Destroy(gameObject);
    }
}
