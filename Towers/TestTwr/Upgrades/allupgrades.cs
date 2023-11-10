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

public class ExplosiveDart : ModUpgrade<BTD1Monkey>
{

    public override int Path => MIDDLE;

    public override int Tier => 1;

    public override int Cost => 100;
    public override string DisplayName => "Explosive Darts";
    public override string Description => "haha dart go BOOM";
    public override string Icon => "yes3";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        towerModel.GetAttackModel().weapons[0] = Game.instance.model.GetTowerFromId("BombShooter").GetAttackModel().weapons[0].Duplicate();
        var attackModel = towerModel.GetAttackModel();
        var projectile = attackModel.weapons[0].projectile;
        projectile.ApplyDisplay<DartDisplay>();
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

