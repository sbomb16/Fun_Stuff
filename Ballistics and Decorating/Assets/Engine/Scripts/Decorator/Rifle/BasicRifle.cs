using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRifle : IRifle
{

    private float m_BasicAccuracy = 5.0f;
    private float m_BasicAmmo = 10f;
    public string prefabPath = "Base Rifle";
    public GameObject model;

    public GameObject GetGameObject()
    {
        return model;
    }

    public BasicRifle(Vector3 worldPos)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab, worldPos, prefab.transform.rotation);
    }

    public BasicRifle()
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(model);
    }

    public float GetAccuracy()
    {
        return m_BasicAccuracy;
    }

    public float GetAmmoCount()
    {
        return m_BasicAmmo;
    }

}
