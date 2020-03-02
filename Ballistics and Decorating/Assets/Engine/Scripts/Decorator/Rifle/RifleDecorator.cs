using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class RifleDecorator : IRifle {

    protected IRifle m_DecoratedRifle;

    public RifleDecorator(IRifle rifle)
    {
        m_DecoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return m_DecoratedRifle.GetAccuracy();
    }

    public virtual float GetAmmoCount()
    {
        return m_DecoratedRifle.GetAmmoCount();
    }

    public GameObject GetGameObject()
    {
        return m_DecoratedRifle.GetGameObject();
    }
	
}
