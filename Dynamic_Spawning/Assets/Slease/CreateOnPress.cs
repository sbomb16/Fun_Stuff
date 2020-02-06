using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateOnPress : MonoBehaviour {

    public Text thingText;

    public Dropdown dropping1;

    GameObject require;

    GameObject newText;

    CreatureRequirements requirements;

    public S_Client spawn;

    public int wealth;
    public int land;
    public bool conscious;
    public bool mysterious;

    private void Start()
    {

        dropping1 = GetComponent<Dropdown>();

        require = GameObject.Find("Requirements");

        newText = GameObject.Find("Canvas/Text");

    }

    public void CreateObjectOnPress()
    {


        requirements = require.GetComponent<CreatureRequirements>();        

        CreatureRequirements requiring = requirements;

        Debug.Log(requiring);

        CreatureFactory factory = new CreatureFactory(requiring);

        

        createFactory(factory);
    }

    public void DropdownChange()
    {
        string option = dropping1.options[dropping1.value].text;

        requirements = require.GetComponent<CreatureRequirements>();

        Debug.Log(require);

        if (option == "Poor")
        {
            requirements.Wealth = 1;
        }
        else if(option == "Doing ok")
        {
            requirements.Wealth = 2;
        }
        else if(option == "Very well")
        {
            requirements.Wealth = 3;
        }
        else if(option == "Millionaire")
        {
            requirements.Wealth = 4;
        }

        if(option == "Conscious")
        {
            requirements.Conscious = true;
        }
        else if(option == "Egg")
        {
            requirements.Conscious = false;
        }

        if(option == "None")
        {
            requirements.Land = 0;
        }
        else if(option == "Some"){

            requirements.Land = 1;
        }
        else if(option == "Lots")
        {
            requirements.Land = 2;
        }

        if(option == "Mysterious")
        {
            requirements.Mysterious = true;
        }
        else if(option == "Normal")
        {
            requirements.Mysterious = false;
        }
    }

    public void createFactory(CreatureFactory factory)
    {

        CreatureRequirements textRequire = newText.GetComponent<CreatureRequirements>();

        Debug.Log(factory);
        ICreature c = factory.Create();        
        InstantiateNewObjects(c.ToString());
        Debug.Log(c);

        textRequire.objectText.text = c.ToString();

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

            case "Millionaire":
                GameObject millionaire_obj = Instantiate(Resources.Load("Millionaire")) as GameObject;
                return millionaire_obj;

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

            case "Egg":
                GameObject egg_obj = Instantiate(Resources.Load("Egg")) as GameObject;
                return egg_obj;

            case "Well_Off_Egg":
                GameObject well_off_egg_obj = Instantiate(Resources.Load("Well-Off Egg")) as GameObject;
                return well_off_egg_obj;

            case "Super_Hero":
                GameObject superhero_obj = Instantiate(Resources.Load("Superhero")) as GameObject;
                return superhero_obj;

            case "Mega_Egg":
                GameObject mega_egg_obj = Instantiate(Resources.Load("Mega_Egg")) as GameObject;
                return mega_egg_obj;

            default:
                return Instantiate(Resources.Load("Beggar")) as GameObject;

        }
    }

}
