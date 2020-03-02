using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateOnPress : MonoBehaviour {

    public Text thingText;

    public Dropdown dropping1;

    GameObject require;

    GameObject newText;

    GunRequirements requirements;

    public S_Client spawn;
    public Client g_spawn;

    public int magazine;
    public int accuracy;
    public bool size;

    private void Start()
    {

        dropping1 = GetComponent<Dropdown>();

        g_spawn = new Client();

        require = GameObject.Find("Requirements");

        newText = GameObject.Find("Canvas/Gun Name");

    }

    public void CreateObjectOnPress()
    {
        
        requirements = require.GetComponent<GunRequirements>();

        GunRequirements requiring = requirements;

        //Debug.Log(requiring);

        GunFactory factory = new GunFactory(requiring);        

        createFactory(factory);

    }

    public void DropdownChange()
    {
        string option = dropping1.options[dropping1.value].text;

        requirements = require.GetComponent<GunRequirements>();

        //Debug.Log(require);

        if (option == "Small")
        {
            requirements.Magazine = 1;
        }
        else if(option == "Average")
        {
            requirements.Magazine = 2;
        }
        else if(option == "Encumbering")
        {
            requirements.Magazine = 3;
        }

        if(option == "Pistol")
        {
            requirements.Size = true;
        }
        else if(option == "Rifle")
        {
            requirements.Size = false;
        }

        if(option == "None")
        {
            requirements.Accuracy = 0;
        }
        else if(option == "Some"){

            requirements.Accuracy = 1;
        }
        else if(option == "Lots")
        {
            requirements.Accuracy = 2;
        }
    }

    public void createFactory(GunFactory factory)
    {

        GunRequirements textRequire = newText.GetComponent<GunRequirements>();

        //Debug.Log(factory);
        IGun c = factory.Create();
        //Debug.Log(c);
        g_spawn.GetGun(c.ToString());
        //Debug.Log(c);

        textRequire.objectText.text = c.ToString();

    }
}
