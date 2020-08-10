using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : MonoBehaviour
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
        Gamemanager.Instance.AddScore();
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plane")
        {
            Destroy(gameObject);
            Gamemanager.Instance.DamageLife();

        }
    }


}
