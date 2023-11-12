using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using UnityEngine;
using Il2CppAssets.Scripts.Unity.UI_New.Upgrade;
using System.Runtime.InteropServices;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Unity;
using EcoTowers.Towers.TestTwr.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Xml.Linq;
using UnityEngine.UIElements;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;

namespace EcoTowers.Towers.TestTwr;



public class Piercing_Darts : ModUpgrade<BTD1Monkey>
{

    public override int Path => TOP;

    public override int Tier => 1;

    public override int Cost => 210;
    public override string DisplayName => "Piercing Darts";
    public override string Description => "Allows A Dart Monkey to Pop through 2 Bloons with 1 Dart";
    public override string Icon => "yes2";
    public override void ApplyUpgrade(TowerModel towerModel)
    {;
        var attackModel = towerModel.GetAttackModel();
        var proj = attackModel.weapons[0].projectile;
        proj.pierce = 2;
    }
}

public class ppd : ModUpgrade<BTD1Monkey>
{

    public override int Path => TOP;

    public override int Tier => 2;

    public override int Cost => 445;
    public override string DisplayName => "More Powerfull Darts";
    public override string Description => "Darts now have more power and pierce";
    public override string Icon => "top2";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        ;
        var attackModel = towerModel.GetAttackModel();
        var proj = attackModel.weapons[0].projectile;
        proj.pierce = 3;
        proj.GetDamageModel().damage = 2;
    }
}

public class dg : ModUpgrade<BTD1Monkey>
{

    public override int Path => TOP;

    public override int Tier => 3;

    public override int Cost => 798;
    public override string DisplayName => "Dart Rifle";
    public override string Description => "The dart monkey now uses a dart rifle to shoot the bloons";
    public override string Icon => "top3";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        ;
        var attackModel = towerModel.GetAttackModel();
        var proj = attackModel.weapons[0].projectile;
        towerModel.GetAttackModel().weapons[0].rate *= 0.50f;
    }
}

public class mm : ModUpgrade<BTD1Monkey>
{

    public override int Path => TOP;

    public override int Tier => 4;

    public override int Cost => 500;
    public override string DisplayName => "Monkey Military";
    public override string Description => "Enlist in the monkey military, training your attack range";
    public override string Icon => "top4";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        ;
        var attackModel = towerModel.GetAttackModel();
        var proj = attackModel.weapons[0].projectile;
        towerModel.range = 40;
        attackModel.range = 40;
    }
}

public class mini : ModUpgrade<BTD1Monkey>
{

    public override int Path => TOP;

    public override int Tier => 5;

    public override int Cost => 5000;
    public override string DisplayName => "Minigun";
    public override string Description => "The mother of all weapons...";
    public override string Icon => "top5";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        ;
        var attackModel = towerModel.GetAttackModel();
        var proj = attackModel.weapons[0].projectile;
        towerModel.GetAttackModel().weapons[0].rate *= 0.35f;
    }
}

public class ExplosiveDart : ModUpgrade<BTD1Monkey>
{

    public override int Path => MIDDLE;

    public override int Tier => 1;

    public override int Cost => 335;
    public override string DisplayName => "Fire Darts";
    public override string Description => "Can pop leads";
    public override string Icon => "yes3";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
      
        var attackModel = towerModel.GetAttackModel();
        var projectile = attackModel.weapons[0].projectile;
        var DamageModel = projectile.GetDamageModel();
        projectile.ApplyDisplay<Burnydarts>();
        DamageModel.immuneBloonProperties = BloonProperties.Frozen;
    }
}

public class BiggerBoom : ModUpgrade<BTD1Monkey>
{

    public override int Path => MIDDLE;

    public override int Tier => 2;

    public override int Cost => 300;
    public override string DisplayName => "Burning Darts";
    public override string Description => "Darts deal 2x damage";
    public override string Icon => "mid2";
    public override void ApplyUpgrade(TowerModel towerModel)
    {      
        var attackModel = towerModel.GetAttackModel();
        var projectile = attackModel.weapons[0].projectile;
        projectile.GetDamageModel().damage = 2;
    }
}

public class CannonBaller : ModUpgrade<BTD1Monkey>
{

    public override int Path => MIDDLE;

    public override int Tier => 3;

    public override int Cost => 655;
    public override string DisplayName => "Cannon";
    public override string Description => "Gain a cannon boosting damage and pierce also slighty buffs range";
    public override string Icon => "mid3";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        var bomb = Game.instance.model.GetTower("BombShooter", 2, 0, 0).GetWeapon().projectile.Duplicate();
        bomb.pierce = 6f;
        bomb.scale = 0.3f;
        towerModel.GetWeapon().projectile = bomb;
        var attackModel = towerModel.GetAttackModel();
        var projectile = attackModel.weapons[0].projectile;
        towerModel.GetAttackModel().weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage = 3;
        projectile.pierce = 3;
        towerModel.range = 45;
        attackModel.range = 45;

    }
}

public class CannonBaller2 : ModUpgrade<BTD1Monkey>
{

    public override int Path => MIDDLE;

    public override int Tier => 4;

    public override int Cost => 1350;
    public override string DisplayName => "Double Cannon";
    public override string Description => "Gain a second cannon";
    public override string Icon => "mid3";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        var attackModel = towerModel.GetAttackModel();
        var projectile = attackModel.weapons[0].projectile;
        towerModel.GetWeapon().emission = new ParallelEmissionModel("ParrarelEmmisionModel", 2, 3, 1, false, null);

    }
}

public class EvenStrongercanon : ModUpgrade<BTD1Monkey>
{

    public override int Path => MIDDLE;

    public override int Tier => 5;

    public override int Cost => 13000;
    public override string DisplayName => "Powerfull Cannon's";
    public override string Description => "You need explosion strength? We got explosion strength.";
    public override string Icon => "mid3";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        var attackModel = towerModel.GetAttackModel();
        var projectile = attackModel.weapons[0].projectile;
        projectile.pierce = 50;
        towerModel.GetAttackModel().weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage = 7;
        towerModel.GetWeapon().projectile.scale = 0.7f;
    }
}


public class LongerRanger : ModUpgrade<BTD1Monkey>
{

    public override int Path => BOTTOM;

    public override int Tier => 1;

    public override int Cost => 100;
    public override string DisplayName => "Long Range Darts";
    public override string Description => "Allows A Dart Monkey to Have More Range";
    public override string Icon => "yes";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        towerModel.range = 35;
        var attackModel = towerModel.GetAttackModel();
        attackModel.range = 35;
        
    }
}

public class doubleshot : ModUpgrade<BTD1Monkey>
{

    public override int Path => BOTTOM;

    public override int Tier => 2;

    public override int Cost => 550;
    public override string DisplayName => "Double Shot";
    public override string Description => "Shoots 2 darts instead of one";
    public override string Icon => "bot2";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel", 2, 9, 10, null, false, false);     
        var attackModel = towerModel.GetAttackModel();
    }
}

public class camoshoot : ModUpgrade<BTD1Monkey>
{

    public override int Path => BOTTOM;

    public override int Tier => 3;

    public override int Cost => 350;
    public override string DisplayName => "Camo Sight";
    public override string Description => "Allows the dart monkey to shoot camo";
    public override string Icon => "bot3";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        
        var attackModel = towerModel.GetAttackModel();
        var projectile = attackModel.weapons[0].projectile;
        towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
    }
}

public class evenlongerrange : ModUpgrade<BTD1Monkey>
{

    public override int Path => BOTTOM;

    public override int Tier => 4;

    public override int Cost => 733;
    public override string DisplayName => "Even Longer Range";
    public override string Description => "Allows the dart monkey to shoot pretty far";
    public override string Icon => "bot4";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        towerModel.range = 65;
        var attackModel = towerModel.GetAttackModel();
        attackModel.range = 65;
    }
}

public class quickshots : ModUpgrade<BTD1Monkey>
{

    public override int Path => BOTTOM;

    public override int Tier => 5;

    public override int Cost => 4352;
    public override string DisplayName => "Extremely Fast Shooting";
    public override string Description => "You need attack speed? We have attack speed.";
    public override string Icon => "bot5";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        var attackModel = towerModel.GetAttackModel();
        var proj = attackModel.weapons[0].projectile;
        towerModel.GetAttackModel().weapons[0].rate *= 0.25f;
    }
}