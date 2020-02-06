using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Factory : MonoBehaviour {

    // Get instances of each type of character to spawn
    Beggars m_beg;
    Farmers m_farm;
    Shop_Owners m_shop_owner;
    Small_Eggs m_small_egg;

    // Called on startup
    void Start()
    {

        // Instantiates the corresponding objects(beggar, egg, etc) by finding the corresponding prefab within the resources folder
        GameObject beg_obj = Instantiate(Resources.Load("Prefabs_2/Beggar")) as GameObject;
        m_beg = beg_obj.GetComponent<Beggars>();

        GameObject farm_obj = Instantiate(Resources.Load("Prefabs_2/Farmer")) as GameObject;
        m_farm = farm_obj.GetComponent<Farmers>();

        GameObject shop_owner_obj = Instantiate(Resources.Load("Prefabs_2/Shop_Owner")) as GameObject;
        m_shop_owner = shop_owner_obj.GetComponent<Shop_Owners>();

        GameObject small_egg_obj = Instantiate(Resources.Load("Prefabs_2/Small_Egg")) as GameObject;
        m_small_egg = small_egg_obj.GetComponent<Small_Eggs>();

    }
    
    // Gets the NPC's and creates a copy 
    public iCopyable GetNPC(NPCType type)
    {

        // Checks to see what is being called
        switch (type)
        {
            
            // If the case found is the corresponding NPC type, call its class, specifically the Copy() function, and return it to the NPCSpawner
            case NPCType.Beggar:                
                iCopyable beggar = m_beg.Copy();
                return beggar;               

            case NPCType.Shop_Owner:
                iCopyable shop_owner = m_shop_owner.Copy();
                return shop_owner;
                
            case NPCType.Farmer:
                iCopyable farmer = m_farm.Copy(); ;
                return farmer;

            case NPCType.Small_egg:
                iCopyable small_egg = m_small_egg.Copy();
                return small_egg;

        }

        // Returns null if none of the cases match
        return null;

    }
}
