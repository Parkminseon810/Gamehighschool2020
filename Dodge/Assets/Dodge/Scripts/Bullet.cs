using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //m_Velocity = tranceform.forward;
    }
    public Vector3 m_Velocity;

    public float m_speed = 5f;

    public float m_DestroyCooltime = 5f;
    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidibody = /*gameObject*/GetComponent<Rigidbody>();

        rigidibody.AddForce(m_Velocity * m_speed);

        m_DestroyCooltime = m_DestroyCooltime- Time.deltaTime;

        if (m_DestroyCooltime <= 0)
            Destroy(gameObject);

        
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.tag == "Player")
        {
            var player = other.attachedRigidbody.GetComponent<PlayerController>();
            player.Die();
        }
        
            
    }
}
