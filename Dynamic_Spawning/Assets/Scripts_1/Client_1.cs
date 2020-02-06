using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client_1 : MonoBehaviour {

    public Drone m_Drone;
    public Sniper m_Sniper;
    public Funny_Man m_Funny_Man;
    public EnemySpawner m_Spawner;

    private Enemy m_Spawn;

    private int m_IncrementDrone = 0;
    private int m_IncrementSniper = 0;
    private int m_IncrementFunny_Man = 0;

    Vector3 moveLeft = new Vector3(1, 0, 0);

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {

            m_Spawn = m_Spawner.SpawnEnemy(m_Drone);

            m_Spawn.name = "Drone_Clone_" + m_IncrementDrone;

            m_Spawn.transform.Translate(moveLeft * m_IncrementDrone * 1.5f);

            m_IncrementDrone++;

        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            m_Spawn = m_Spawner.SpawnEnemy(m_Sniper);

            m_Spawn.name = "Sniper_Clone_" + m_IncrementSniper;

            m_Spawn.transform.Translate(moveLeft * m_IncrementSniper * 1.5f);

            m_IncrementSniper++;

        }

        if (Input.GetKeyDown(KeyCode.W))
        {

            m_Spawn = m_Spawner.SpawnEnemy(m_Funny_Man);

            m_Spawn.name = "Funny_Man_Clone_" + m_IncrementFunny_Man;

            m_Spawn.transform.Translate(moveLeft * m_IncrementFunny_Man * 1.5f);

            m_IncrementFunny_Man++;

        }
    }
}
