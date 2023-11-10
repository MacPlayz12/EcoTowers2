using MelonLoader;
using BTD_Mod_Helper;
using EcoTowers;
using BTD_Mod_Helper.Api.Towers;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.TowerSets;

[assembly: MelonInfo(typeof(EcoTowers.EcoTowers), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace EcoTowers;

public class EcoTowers : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<EcoTowers>("mod loaded,it aint good though.");
        ModHelper.Msg<EcoTowers>("i really need to improve stuff.");
        ModHelper.Msg<EcoTowers>("no crosspath support.");
        ModHelper.Msg<EcoTowers>("paths++,custom roundset is PLANNED");
    }

    public class Cool : ModTowerSet
    {
        public override string DisplayName => "Retro Towers";

        public override bool AllowInRestrictedModes => false; // Set to true to still allow these towers in Primary/Military/Magic only, etc


        public override int GetTowerSetIndex(List<TowerSet> towerSets) => towerSets.IndexOf(TowerSet.Military) + 1;
    }
}