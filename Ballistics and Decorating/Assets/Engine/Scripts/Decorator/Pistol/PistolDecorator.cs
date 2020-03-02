using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolDecorator : IPistol {

    protected IPistol m_DecoratedPistol;

    public PistolDecorator(IPistol pistol)
    {
        m_DecoratedPistol = pistol;
    }

    public virtual float GetAccuracy()
    {
        return m_DecoratedPistol.GetAccuracy();
    }

    public virtual float GetAmmoCount()
    {
        return m_DecoratedPistol.GetAmmoCount();
    }

    public GameObject GetGameObject()
    {
        return m_DecoratedPistol.GetGameObject();
    }
}
