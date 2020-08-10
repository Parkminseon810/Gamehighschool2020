using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube : MonoBehaviour
{
    public float m_Speed = 5;

    public GameObject m_RedCube;
    void Start()
    {

    }
    //Update is called once per frame
    void Update()
    {
        var movement = Vector3.down * m_Speed * Time.deltaTime;
        transform.position += movement;
    }

    public void OnPointerDownEvent()
    {
        Gamemanager.Instance.DamageLife();
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plane")
        {
            Destroy(gameObject);
            Gamemanager.Instance.AddScore();
        }
    }

   // private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.tag == "plane")
     //   {
     //       Destroy(gameObject);
     //   }
    //}


}
