using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Client : MonoBehaviour
{
    IGun v;

    public Client g_spawn;

    public int Magazine;
    public bool Size;
    public int Accuracy;
    public bool Color;

    // Start is called before the first frame update
    void Start()
    {

        GunRequirements requirements = new GunRequirements
        {

            Magazine = Mathf.Max(Magazine, 1),
            Size = Size,
            Accuracy = Mathf.Max(Accuracy)

        };

        GunFactory factory = new GunFactory(requirements);
        createFactory(factory);
        
    }

    public void createFactory(GunFactory factory)
    {
        Debug.Log(factory);
        IGun c = factory.Create();
        g_spawn.GetGun(c.ToString());
        Debug.Log(c);

    }
}

