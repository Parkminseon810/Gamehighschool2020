using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_Speed = 15f;
    // Update is called once per frame
    
    void Update()
    {
        Rigidbody rigidibody = /*gameObject*/GetComponent<Rigidbody>();

        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        float Fire = Input.GetAxis("Fire1");

        rigidibody.AddForce(new Vector3(xAxis, 0, yAxis) * m_Speed);


        if (Fire > 0) Die();


        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    //transform.position += Vector3.left * m_Speed * Time.deltaTime;
        //
        //    rigidibody.AddForce(Vector3.left * m_Speed);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //   rigidibody.AddForce(Vector3. right * m_Speed);
        //}
        //else if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    rigidibody.AddForce(Vector3.forward * m_Speed);
        //}
        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    rigidibody.AddForce(Vector3.back * m_Speed);
        //}


        //Geaxis fire 사망처리 해보자.


        //if (Input.GetKeyDown(KeyCode.Space))
        //    Die();
    }

    public void Die()
    {
        Debug.Log("사망");
        gameObject.SetActive(false);
    }
}   
