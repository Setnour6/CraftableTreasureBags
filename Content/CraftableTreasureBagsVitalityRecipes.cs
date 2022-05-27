using System;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.DataStructures;
using Terraria.UI;
using Terraria.ID;
using Terraria.IO;
using Terraria.Social;
using Terraria.ModLoader;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.Utilities;
using Terraria.WorldBuilding;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader.IO;
using Terraria.Localization;
using System.Runtime.InteropServices;
using ReLogic.Graphics;
using Terraria.GameContent.UI;
using Terraria.GameContent.ItemDropRules;

namespace CraftableTreasureBags
{
	public class CraftableTreasureBagsVitalityRecipes : ModSystem
	{

		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("VitalityMod", out var VitalityMod)) return;
			{
				if (!ModContent.TryFind("VitalityMod/StormCloudBossBag", out ModItem StormCloudBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/GrandAntlionBossBag", out ModItem GrandAntlionBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/MoonlightDragonflyBossBag", out ModItem MoonlightDragonflyBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/DreadnaughtBossBag", out ModItem DreadnaughtBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/AnarchulesBeetleBossBag", out ModItem AnarchulesBeetleBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/AnarchulesBeetleCrimsonBossBag", out ModItem AnarchulesBeetleCrimsonBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/ChaosbringerBossBag", out ModItem ChaosbringerBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/PaladinSpiritBossBag", out ModItem PaladinSpiritBossBag)) return; //VitalityMod

				StormCloudBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.PureVase>().AddIngredient(VitalityMod, "CloudCore").AddIngredient(1243, 1).AddIngredient(317, 3).AddIngredient(VitalityMod, "CloudVapor", 28).AddIngredient(VitalityMod, "StormCloudMask").AddTile(26).AddCondition(Recipe.Condition.NearWater).Register(); //Storm Cloud Phase 1 Type
				StormCloudBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.PureVase>().AddIngredient(VitalityMod, "CloudCore").AddIngredient(1243, 1).AddIngredient(317, 3).AddIngredient(VitalityMod, "CloudVapor", 28).AddIngredient(VitalityMod, "StormCloudMask2").AddTile(26).AddCondition(Recipe.Condition.NearWater).Register(); //Storm Cloud Phase 2 Type
				GrandAntlionBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.PureVase>().AddIngredient(VitalityMod, "AncientCrown").AddIngredient(VitalityMod, "AntlionHide").AddIngredient(VitalityMod, "DriedBar", 22).AddIngredient(169, 50).AddIngredient(3271, 50).AddIngredient(VitalityMod, "GrandAntlionMask").AddTile(26).Register(); //The Grand Antlion
				MoonlightDragonflyBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.PureVase>().AddIngredient(VitalityMod, "MoonlightLotusFlower").AddIngredient(VitalityMod, "GlowingGraniteBar", 3).AddIngredient(314, 3).AddIngredient(VitalityMod, "MoonlightDragonflyMask").AddTile(26).Register(); //Moonlight Dragonfly
																																																																																						   // Hardmode Recipes Start Here
				DreadnaughtBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.FireFrostVase>().AddIngredient(VitalityMod, "Dreadcandle").AddIngredient(175, 12).AddIngredient(318, 5).AddIngredient(VitalityMod, "DreadnaughtMask").AddTile(26).Register(); //Dreadnaught
				AnarchulesBeetleBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.FireFrostVase>().AddIngredient(VitalityMod, "AnarchyCrystal").AddIngredient(VitalityMod, "AnarchyBar", 40).AddIngredient(60, 20).AddIngredient(316, 5).AddIngredient(VitalityMod, "AnarchulesBeetleMask").AddTile(26).Register(); //Anarchules Beetle (Corruption)
				AnarchulesBeetleCrimsonBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.FireFrostVase>().AddIngredient(VitalityMod, "AnarchyCrystalCrimson").AddIngredient(VitalityMod, "AnarchyBarCrimson", 40).AddIngredient(2887, 20).AddIngredient(316, 5).AddIngredient(VitalityMod, "AnarchulesBeetleCrimsonMask").AddTile(26).Register(); //Anarchules Beetle (Crimson)
				ChaosbringerBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.FireFrostVase>().AddIngredient(VitalityMod, "TotemofChaos").AddIngredient(VitalityMod, "ChaosBar", 40).AddIngredient(VitalityMod, "ChaosCrystal", 100).AddIngredient(2317).AddIngredient(315, 3).AddIngredient(VitalityMod, "ChaosbringerMask").AddTile(26).Register(); //Chaosbringer
				PaladinSpiritBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.FireFrostVase>().AddIngredient(VitalityMod, "SpiritBox").AddIngredient(VitalityMod, "EquityCore").AddIngredient(VitalityMod, "SoulofVitality", 40).AddIngredient(VitalityMod, "Ectosoul", 25).AddIngredient(314, 5).AddIngredient(VitalityMod, "PaladinSpiritMask").AddTile(26).Register(); //Paladin Spirit

			}
		}
	}
}