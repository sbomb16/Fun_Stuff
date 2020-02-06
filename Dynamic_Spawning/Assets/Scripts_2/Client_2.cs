using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client_2 : MonoBehaviour {

    public NPCSpawner m_SpawnerNPC;

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

            m_SpawnerNPC.SpawnVillagers();

        }
    }
}
