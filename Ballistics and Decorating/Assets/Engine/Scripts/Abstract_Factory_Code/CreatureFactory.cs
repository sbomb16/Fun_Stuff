using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGunFactory {

    IGun Create(GunRequirements requirements);

}

public class GunFactory {

    private readonly IGunFactory _factory;
    private readonly GunRequirements _requirements;

    public GunFactory(GunRequirements requirements)
    {

        _factory = requirements.Size ? (IGunFactory)new PistolFactory() : new RifleFactory();
        _requirements = requirements;

    }

    public IGun Create()
    {

        return _factory.Create(_requirements);
        
    }
}

public class PistolFactory : IGunFactory {

    public IGun Create(GunRequirements requirements)
    {

        switch (requirements.Magazine)
        {

            case 1:
                if (requirements.Accuracy == 0) return new FuddGun();
                return new BasePistol();

            case 2:
                if (requirements.Accuracy == 1) return new RangePistol();
                return new LargePistol();

            case 3:
                if (requirements.Accuracy == 2) return new TargetPistol();
                return new EncumberedPistol();

            default:
                return new BasePistol();

        }
    }
}

public class RifleFactory : IGunFactory {

    public IGun Create(GunRequirements requirements)
    {

        switch (requirements.Magazine)
        {

            case 1:                
                return new BaseRifle();

            case 2:
                if(requirements.Accuracy == 2) { return new Sniper(); }
                if (requirements.Accuracy == 0) { return new SubMachineGun(); }
                return new LargeRifle();

            case 3:                
                return new LightMachineGun();                

            default:
                return new BaseRifle();

        }
    }
}
