using BTD_Mod_Helper.Api.Display;
using EcoTowers.Towers.TestTwr;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTowers.Image
{
    public class BTD1MonkeyDisplay : ModTowerDisplay<BTD1Monkey>
    {

        public override bool UseForTower(int[] tiers)
        {
            return tiers.Sum() == 0;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            // Print info about the node in order to edit it easier


        }
    }
}