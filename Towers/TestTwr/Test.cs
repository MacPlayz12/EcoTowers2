using System.Collections.Generic;
using System.Linq;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using EcoTowers.Towers.TestTwr.Projectiles;
using BTD_Mod_Helper.Api.Helpers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using EcoTowers;
namespace EcoTowers.Towers.TestTwr
{
    /// <summary>
    /// The main class that adds the core tower to the game
    /// </summary>
    public class BTD1Monkey : ModTower
    {
         public override string Get2DTexture(int[] tiers)
        {

            if (tiers[0] == 1)
            {
                return "top1";
            }

            else if (tiers[2] == 1)
            {
                return "bottom1";
            }
            
            else if (tiers[2] == 2)
            {
                return "bottom2";
            }
            
            else if (tiers[1] == 1)
            {
                return "middle1";
            }    

            else
            {
                return "BTD1Monkey";
            }

        }
        public override string Portrait => "BTD1Monkey";
        public override string Icon => "BTD1Monkey";
        public override bool Use2DModel => true;

        public override TowerSet TowerSet => TowerSet.Primary;

        public override string BaseTower => TowerType.DartMonkey;
        public override int Cost => 250;


        public override int TopPathUpgrades => 1;
        public override int MiddlePathUpgrades => 1;
        public override int BottomPathUpgrades => 2;
        public override string Description => "The original dart monkey!";

        public override string DisplayName => "OG Dart Monkey";




        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.range = 25;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range = 25;

            var projectile = attackModel.weapons[0].projectile;
            projectile.ApplyDisplay<DartDisplay>();
            projectile.pierce = 1;
            projectile.GetDamageModel().damage = 1;
            towerModel.GetAttackModel().weapons[0].rate = 1;
        }
    /// <summary>
    /// Make Card Monkey go right after the Boomerang Monkey in the shop
    /// <br />
    /// If we didn't have this, it would just put it at the end of the Primary section
    /// </summary>
    public override int GetTowerIndex(List<TowerDetailsModel> towerSet)
        {
            return towerSet.First(model => model.towerId == TowerType.DartMonkey).towerIndex + 1;
        }

    }
}