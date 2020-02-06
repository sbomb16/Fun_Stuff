using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Client : MonoBehaviour
{
    ICreature v;

    // Get instances of each type of character to spawn
    Small_Egg m_Small_Egg;
    Large_Egg m_Large_Egg;
    Mysterious_Egg m_Mysterious_Egg;

    Beggar m_Beg;
    Shop_Owner m_Shop_Owner;
    Farmer m_Farmer;

    public GameObject beg_obj;
    public GameObject farm_obj;
    public GameObject shop_owner_obj;
    public GameObject small_egg_obj;
    public GameObject large_egg_obj;
    public GameObject mysterious_egg_obj;


    public int Wealth;
    public bool Conscious;
    public int Land;
    public bool Mysterious;

    // Start is called before the first frame update
    void Start()
    {

        CreatureRequirements requirements = new CreatureRequirements
        {

            Wealth = Mathf.Max(Wealth, 1),
            Conscious = Conscious,
            Land = Mathf.Max(Land)

        };

        //requirements.Conscious = Cargo;
        requirements.Mysterious = Mysterious;

        CreatureFactory factory = new CreatureFactory(requirements);
        createFactory(factory);
        
    }

    public void createFactory(CreatureFactory factory)
    {
        Debug.Log(factory);
        ICreature c = factory.Create();
        InstantiateNewObjects(c.ToString());
        Debug.Log(c);

    }

    public GameObject InstantiateNewObjects(string spawning)
    {
        switch (spawning)
        {
            case "Beggar":
                GameObject beg_obj = Instantiate(Resources.Load("Beggar")) as GameObject;
                return beg_obj;
                //m_Beg = beg_obj.GetComponent<Beggar>();

            case "Farmer":
                GameObject farm_obj = Instantiate(Resources.Load("Farmer")) as GameObject;
                return farm_obj;
                //m_Farmer = farm_obj.GetComponent<Farmer>();

            case "Shop_Owner":
                GameObject shop_owner_obj = Instantiate(Resources.Load("Shop_Owner")) as GameObject;
                return shop_owner_obj;
                //m_Shop_Owner = shop_owner_obj.GetComponent<Shop_Owner>();

            case "Small_Egg":
                GameObject small_egg_obj = Instantiate(Resources.Load("Small_Egg")) as GameObject;
                return small_egg_obj;
            //m_Small_Egg = small_egg_obj.GetComponent<Small_Egg>();

            case "Large_Egg":
                GameObject large_egg_obj = Instantiate(Resources.Load("Large_Egg")) as GameObject;
                return large_egg_obj;
            //m_Large_Egg = large_egg_obj.GetComponent<Large_Egg>();

            case "Mysterious_Egg":
                GameObject mysterious_egg_obj = Instantiate(Resources.Load("Mysterious_Egg")) as GameObject;
                return mysterious_egg_obj;
            //m_Mysterious_Egg = mysterious_egg_obj.GetComponent<Mysterious_Egg>();

            default:                
                return Instantiate(Resources.Load("Beggar")) as GameObject;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

