using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
        public Animator m_Animator;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            m_Animator.SetTrigger("Attack");
    }
}
