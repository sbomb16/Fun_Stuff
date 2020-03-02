using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithScope : RifleDecorator {

    private float m_ScopeAccuracy = 25.0f;
    public string prefabPath = "Rifle With Scope";
    public GameObject model;

    public WithScope(IRifle rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccuracy;
    }
}
