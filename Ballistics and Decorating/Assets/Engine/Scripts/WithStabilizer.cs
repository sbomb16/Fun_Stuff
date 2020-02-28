using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithStabilizer : RifleDecorator {

    private float m_StabilizerAccuracy = 20.0f;
    public string prefabPath = "With Stabilizer";
    public GameObject model;

    public WithStabilizer(IRifle rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StabilizerAccuracy;
    }
}
