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
    public class BTD1Monkey : ModTower<EcoTowers.Cool>
    {
         public override string Get2DTexture(int[] tiers)
        {



            if (tiers[2] == 5)
            {
                return "bottom5";
            }
            else if (tiers[2] == 4)
            {
                return "bottom4";
            }

            else if (tiers[2] == 3)
            {
                return "bottom3";
            }

            else if (tiers[1] == 5)
            {
                return "middle5";
            }



            else if (tiers[1] == 4)
            {
                return "middle4";
            }

            else if (tiers[0] == 5)
            {
                return "topp5";
            }


            else if (tiers[0] == 4)
            {
                return "topp4";
            }


            else if (tiers[0] == 3)
            {
                return "topp3";
            }

            else if (tiers[1] == 3)
            {
                return "middle3";
            }

            else if (tiers[2] == 2)
            {
                return "bottom2";
            }

            else if (tiers[1] == 2)
            {
                
                return "middle2";
            }

            else if (tiers[0] == 2)
            {
                return "topp2";
            }


            else if (tiers[2] == 1)
            {
                return "bottom1";
            }

            else if (tiers[0] == 1)
            {
                return "topp1";
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


        public override string BaseTower => TowerType.DartMonkey;
        public override int Cost => 250;


        public override int TopPathUpgrades => 5;
        public override int MiddlePathUpgrades => 5;
        public override int BottomPathUpgrades => 5;
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