using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICreatureFactory {
    ICreature Create(CreatureRequirements requirements);
}

public class CreatureFactory {

    private readonly ICreatureFactory _factory;
    private readonly CreatureRequirements _requirements;

    public CreatureFactory(CreatureRequirements requirements)
    {

        _factory = requirements.Conscious ? (ICreatureFactory)new HumanFactory() : new NonHumanFactory();
        _requirements = requirements;

    }

    public ICreature Create()
    {

        return _factory.Create(_requirements);
        
    }
}

public class HumanFactory : ICreatureFactory {

    public ICreature Create(CreatureRequirements requirements)
    {

        switch (requirements.Wealth)
        {

            case 1:
                return new Beggar();

            case 2:
                if (requirements.Land == 1) return new Farmer();
                return new Civilian();

            case 3:
                if (requirements.Land == 1) return new Shop_Owner();
                return new Business_Owner();

            case 4:
                if (requirements.Mysterious) return new Super_Hero();
                return new Millionaire();

            default:
                return new Civilian();

        }
    }
}

public class NonHumanFactory : ICreatureFactory {

    public ICreature Create(CreatureRequirements requirements)
    {

        switch (requirements.Wealth)
        {

            case 1:
                return new Small_Egg();

            case 2:
                if(requirements.Mysterious) { return new Mysterious_Egg(); }
                return new Large_Egg();

            case 3:
                return new Well_Off_Egg();

            case 4:
                if(requirements.Land == 2) { return new Mega_Egg(); }
                return new Egg();

            default:
                return new Small_Egg();

        }
    }
}
