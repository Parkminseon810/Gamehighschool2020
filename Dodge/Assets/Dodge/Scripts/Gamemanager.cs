using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Text m_ScoreUI;
    public Text m_RestartUI;

    public PlayerController m_playerController;
    public List<Gamemanager> m_BulletSpawners;

    public bool m_Isplaying;
    public float m_Score;


    private void Start()
    {


    }
    //Update is called once per frame
    void Update()
    {
        //시간당 점수업
        if (m_Isplaying)
        {
            m_Score = m_Score + Time.deltaTime;
            m_ScoreUI.text = string.Format("Score : (0)", m_Score);

        }
    }

}
    //else
    //{
    //    if (input.GetKeyDown(KeyCode.R))
    //    {
    //        GameStart();
    //    }
    //}