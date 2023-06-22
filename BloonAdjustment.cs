
global using BloonAdjustment;
global using Il2CppAssets.Scripts.Models;
global using Il2CppAssets.Scripts.Models.Towers.Mods;
global using BTD_Mod_Helper;
global using BTD_Mod_Helper.Api.Enums;
global using BTD_Mod_Helper.Api.Helpers;
global using BTD_Mod_Helper.Api.ModOptions;
global using BTD_Mod_Helper.Extensions;
global using Il2CppSystem.Collections.Generic;
global using MelonLoader;

global using BTD_Mod_Helper.Api.Bloons;
global using BTD_Mod_Helper.Api.Display;
global using BTD_Mod_Helper.Api.Scenarios;

global using Il2CppAssets.Scripts.Models.Bloons;
global using Il2CppAssets.Scripts.Models.Difficulty;
global using Il2CppAssets.Scripts.Models.Rounds;
global using Il2CppAssets.Scripts.Models.Towers.Behaviors;
global using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
global using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
global using Il2CppAssets.Scripts.Models.TowerSets;
global using Il2CppAssets.Scripts.Models.TowerSets.Mods;
global using Il2CppAssets.Scripts.Simulation.Behaviors;
global using Il2CppAssets.Scripts.Simulation.Bloons;
global using Il2CppAssets.Scripts.Simulation.SMath;
global using Il2CppAssets.Scripts.Unity;
//global using Il2CppSystem;
global using System.Linq;
global using BTD_Mod_Helper.Api.Components;
global using BTD_Mod_Helper.Api;
global using UnityEngine;
global using BTD_Mod_Helper.UI.Menus;
global using Random = System.Random;
global using TaskScheduler = BTD_Mod_Helper.Api.TaskScheduler;
global using Il2CppAssets.Scripts.Unity.Menu;
global using Il2CppAssets.Scripts.Unity.UI_New;
global using Il2CppAssets.Scripts.Simulation.Towers.Filters;
global using Il2CppAssets.Scripts.Models.Towers.Filters;
global using System;



global using System.Reflection;
global using System.Runtime.CompilerServices;



global using Il2CppAssets.Scripts.Data;
global using Il2CppAssets.Scripts.Data.MapSets;
//global using Il2CppAssets.Scripts.Models;

global using Il2CppAssets.Scripts.Models.Map;
global using Il2CppAssets.Scripts.Models.Towers;

global using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
global using Il2CppAssets.Scripts.Models.Towers.Projectiles;

global using Il2CppAssets.Scripts.Models.Towers.Weapons;

global using Il2CppAssets.Scripts.Unity.Bridge;
global using Il2CppAssets.Scripts.Unity.Display;
global using Il2CppAssets.Scripts.Unity.Map;

global using Il2CppAssets.Scripts.Unity.UI_New.InGame;
global using Il2CppNinjaKiwi.Common;
using Harmony;
using Il2Cpp;
using Il2CppAssets.Scripts.Simulation.Bloons.Behaviors;
using Il2CppAssets.Scripts.Unity.UI_New.ChallengeEditor;
using Il2CppNinjaKiwi.NKMulti.IO;
using Il2CppTMPro;
using System.IO;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppAssets.Scripts.Models.Gameplay.Mods;

[assembly: MelonInfo(typeof(BloonAdjustment.BloonAdjustment), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BloonAdjustment;

public class BloonAdjustment : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<BloonAdjustment>("BloonAdjustment loaded!");
    }
    public class BloonAdjustmentSet : ModRoundSet
    {
        public override string BaseRoundSet => RoundSetType.Default;
        public override int DefinedRounds => BaseRounds.Count;
        public override string DisplayName => "BloonAdjustment";
        public override string Icon => VanillaSprites.BloonAreaDenialSystemUpgradeIcon;

        public override void ModifyRoundModels(RoundModel roundModel, int round)
        {
            var regrowtimes = 0;
            var camotimes = 0;
            var fortatimes = 0;
            var promotetimes = 0;
            foreach (var group in roundModel.groups)

            {

               

                var bloon = Game.instance.model.GetBloon(group.bloon);
                var blooncount = group.count;
                var startTime = group.start;
                var endTime = group.end;
                for (int i = 0; i < blooncount; i++)
                {
                    regrowtimes += 1;
                    camotimes += 1;
                    fortatimes += 1;
                    promotetimes += 1;
                    if (promotetimes == 2)
                    {
                        var chosenBloon = BloonType.Purple;
                        if (bloon.name == "Red")
                        {
                            chosenBloon = BloonType.Blue;
                        }
                        if (bloon.name == "Blue")
                        {
                            chosenBloon = BloonType.Green;
                        }
                        if (bloon.name == "Green")
                        {
                            chosenBloon = BloonType.Yellow;
                        }
                        if (bloon.name == "Yellow")
                        {
                            chosenBloon = BloonType.Pink;
                        }
                        if (bloon.name == "Pink")
                        {
                            chosenBloon = BloonType.Black;
                        }
                        if (bloon.name == "White")
                        {
                            chosenBloon = BloonType.Zebra;
                        }
                        if (bloon.name == "Black")
                        {
                            chosenBloon = BloonType.Zebra;
                        }
                        if (bloon.name == "Zebra")
                        {
                            chosenBloon = BloonType.Rainbow;
                        }
                        if (bloon.name == "Rainbow")
                        {
                            chosenBloon = BloonType.Ceramic;
                        }
                        if (bloon.name == "Purple")
                        {
                            chosenBloon = BloonType.Lead;
                        }
                        if (bloon.name == "Ceramic")
                        {
                            chosenBloon = BloonType.Moab;
                        }
                        if (bloon.name == "Moab")
                        {
                            chosenBloon = BloonType.MoabFortified;
                        }
                        if (bloon.name == "MoabFortified")
                        {
                            chosenBloon = BloonType.Bfb;
                        }
                        if (bloon.name == "BfbFortified")
                        {
                            chosenBloon = BloonType.Zomg;
                        }
                        if (bloon.name == "Bfb")
                        {
                            chosenBloon = BloonType.BfbFortified;
                        }
                        if (bloon.name == "Zomg")
                        {
                            chosenBloon = BloonType.ZomgFortified;
                        }
                        roundModel.AddBloonGroup(chosenBloon, 1, startTime + (i * 15), endTime);
                        promotetimes = 0;
                    }
                    if (regrowtimes == 3)
                    {
                        if (bloon.FindChangedBloonId(bloonModel => bloonModel.isGrow = true, out var regrowBloon))
                        {
                            roundModel.AddBloonGroup(regrowBloon, 1, startTime + (i * 9), endTime);
                        }
                        regrowtimes = 0;
                    }
                    if (camotimes == 5)
                    {
                        if (bloon.FindChangedBloonId(bloonModel => bloonModel.isCamo = true, out var camoBloon))
                        {
                            roundModel.AddBloonGroup(camoBloon, 1, startTime + (i * 23), endTime);
                        }
                        camotimes = 0;
                    }
                    if (fortatimes == 7)
                    {
                        if (bloon.FindChangedBloonId(bloonModel => bloonModel.isFortified = true, out var fortaBloon))
                        {
                            roundModel.AddBloonGroup(fortaBloon, 1, startTime + (i * 19), endTime);
                        }
                        fortatimes = 0;
                    }
                }
            }
        }
    }
    public class BloonAdjustmentGamemode : ModGameMode
    {
        public override string Difficulty => DifficultyType.Hard;

        public override string BaseGameMode => GameModeType.Hard;

        public override string DisplayName => "Bloon Adjustment";

        public override string Icon => VanillaSprites.FasterBloonsIcon;

        public override void ModifyBaseGameModeModel(ModModel gameModeModel)
        {
            gameModeModel.UseRoundSet<BloonAdjustmentSet>();

        }
    }
}