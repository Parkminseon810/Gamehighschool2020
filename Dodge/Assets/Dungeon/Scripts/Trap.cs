using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


    public class Trap : MonoBehaviour
    {
    public UnityEvent m_OnEventer;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 안에 어떤 collider나 Trigger가 들어갔을때");
        if (other.attachedRigidbody != null)
        {
            var player = other.attachedRigidbody.GetComponent<PlayerController_Dungeon>();
            if (player != null)
                m_OnEventer.Invoke();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("트리거 안에 어떤 collider나 Trigger가 나왔을때");
        //스폰
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("트리거 안에 어떤 collider나 Trigger가 들어갔을때");
    }

}



