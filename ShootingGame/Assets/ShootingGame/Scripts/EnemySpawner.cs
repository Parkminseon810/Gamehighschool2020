using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] m_SpawnPoints;
    public GameObject m_EnemyPrefab;
    public float m_SpawnInterva1Min = 2f;
    public float m_Spawnlnterva1Max = 6f;

    public int m_MinSpawnerCount = 1;
    public int m_MaxSpawnerCount = 4;

    public float m_Spawncooldown = 0f;

    private void Start()
    {
        m_Spawncooldown = Random.Range(m_SpawnInterva1Min, m_Spawnlnterva1Max);
    }

    
    void Update()
    {
        if (m_Spawncooldown <= 0)
        {
            int spawnCout = Random.Range(m_MinSpawnerCount, m_MaxSpawnerCount);

            List<int> spawnNuma = new List<int>();
            for (int i = 0; i < spawnCout; i++)
            {
                int spawnNum;
                do
                {
                    spawnNum = Random.Range(0, m_SpawnPoints.Length);
                }
                while (spawnNuma.Contains(spawnNum));

                spawnNuma.Add(spawnNum);
            }


            //총알 생성
            //for(int i=0; 1 < m_FireMuzzzles.count; i++)
            foreach (var spawnNum in spawnNuma)
            {
                var eulerAangle = m_SpawnPoints[spawnNum].eulerAngles += Vector3.forward * Random.Range(-30f, 30f);

                GameObject bullet = GameObject.Instantiate(m_EnemyPrefab,
                    m_SpawnPoints[spawnNum].position, Quaternion.Euler(eulerAangle));  //불렛 생성.
                
            }
            m_Spawncooldown = Random.Range(m_SpawnInterva1Min, m_Spawnlnterva1Max);

        }
        m_Spawncooldown -= Time.deltaTime;
                
             
    }
}
