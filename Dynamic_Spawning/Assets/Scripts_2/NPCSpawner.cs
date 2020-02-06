using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour {

    // creates an instance of the NPCFactory Class
    public NPC_Factory m_Factory;

    // Creates instances of the various NPC Classes
    private Farmers m_Farmer;
    private Beggars m_Beggar;
    private Shop_Owners m_Shop_Owner;
    private Small_Eggs m_Small_Egg;

    private float incAll;

    // This function creates the various NCP's by getting the GameObject returned by the NPC_Factory class
    public void SpawnVillagers()
    {

        // Sets the NPC GameObjects created in the NPC_Factory class to the NPC instances created above 
        m_Beggar = (Beggars)m_Factory.GetNPC(NPCType.Beggar);
        m_Beggar.transform.Translate(Vector3.forward * incAll * 1.5f);

        m_Shop_Owner = (Shop_Owners)m_Factory.GetNPC(NPCType.Shop_Owner);
        m_Shop_Owner.transform.Translate(Vector3.forward * incAll * 1.5f);

        m_Farmer = (Farmers)m_Factory.GetNPC(NPCType.Farmer);
        m_Farmer.transform.Translate(Vector3.forward * incAll * 1.5f);

        m_Small_Egg = (Small_Eggs)m_Factory.GetNPC(NPCType.Small_egg);
        m_Small_Egg.transform.Translate(Vector3.forward * incAll * 1.5f);

        incAll++;

    }
}
