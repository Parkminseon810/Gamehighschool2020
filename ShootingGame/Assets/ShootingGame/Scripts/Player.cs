using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float m_Speed = 10f;
    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 velocity = (new Vector3(xAxis, yAxis, 0).normalized * m_Speed);

        Vector3 movement = velocity * Time.deltaTime;
        transform.position = transform.position + movement;

    }
}
