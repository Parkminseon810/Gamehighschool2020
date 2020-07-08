using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap2 : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision이 어떤 collision과 충돌이 끝났을때");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("collision이 어떤 collision과 충돌이 일어나고있을때");
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            var player = collision.rigidbody
                 .GetComponent<PlayerController_Dungeon>();
            if (player != null)
                player.Die();
        }

        Debug.Log("collision이 어떤 collision과 충돌이 일어났을때");
    }
}




    
     
