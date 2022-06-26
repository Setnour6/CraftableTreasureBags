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
				if (!ModContent.TryFind("VitalityMod/GemstoneElementalBossBag", out ModItem GemstoneElementalBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/MoonlightDragonflyBossBag", out ModItem MoonlightDragonflyBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/DreadnaughtBossBag", out ModItem DreadnaughtBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/AnarchulesBeetleBossBag", out ModItem AnarchulesBeetleBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/ChaosbringerBossBag", out ModItem ChaosbringerBossBag)) return; //VitalityMod
				if (!ModContent.TryFind("VitalityMod/PaladinSpiritBossBag", out ModItem PaladinSpiritBossBag)) return; //VitalityMod
		
				StormCloudBossBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddIngredient<Items.VitalityModItems.PureVase>()
					.AddIngredient(VitalityMod, "CloudCore")
					.AddIngredient(ItemID.UmbrellaHat, 1)
					.AddIngredient(ItemID.Waterleaf, 3)
					.AddIngredient(VitalityMod, "CloudVapor", 28)
					.AddIngredient(VitalityMod, "StormCloudMask")
					.AddTile(TileID.DemonAltar)
					.AddCondition(Recipe.Condition.NearWater)
					.Register(); //Storm Cloud Phase 1 Type
				StormCloudBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.PureVase>().AddIngredient(VitalityMod, "CloudCore").AddIngredient(ItemID.UmbrellaHat, 1).AddIngredient(ItemID.Waterleaf, 3).AddIngredient(VitalityMod, "CloudVapor", 28).AddIngredient(VitalityMod, "StormCloudMask2").AddTile(TileID.DemonAltar).AddCondition(Recipe.Condition.NearWater).Register(); //Storm Cloud Phase 2 Type
				GrandAntlionBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.PureVase>().AddIngredient(VitalityMod, "AncientCrown").AddIngredient(VitalityMod, "AntlionHide").AddIngredient(VitalityMod, "DriedBar", 22).AddIngredient(ItemID.SandBlock, 50).AddIngredient(ItemID.Sandstone, 50).AddIngredient(VitalityMod, "GrandAntlionMask").AddTile(TileID.DemonAltar).Register(); //The Grand Antlion
				GemstoneElementalBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.PureVase>().AddIngredient(VitalityMod, "MultigemCluster").AddIngredient(ItemID.Geode, 6).AddIngredient(VitalityMod, "RubyPetItem").AddIngredient(VitalityMod, "GemstoneElementalMask").AddTile(TileID.DemonAltar).Register(); //Gemstone Elemental
				MoonlightDragonflyBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.PureVase>().AddIngredient(VitalityMod, "MoonlightLotusFlower").AddIngredient(VitalityMod, "GlowingGraniteBar", 3).AddIngredient(ItemID.Moonglow, 3).AddIngredient(VitalityMod, "MoonlightDragonflyMask").AddTile(TileID.DemonAltar).Register(); //Moonlight Dragonfly
				// Hardmode Recipes Start Here
				DreadnaughtBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.FireFrostVase>().AddIngredient(VitalityMod, "Dreadcandle").AddIngredient(ItemID.HellstoneBar, 12).AddIngredient(ItemID.Fireblossom, 5).AddIngredient(VitalityMod, "DreadnaughtMask").AddTile(TileID.DemonAltar).Register(); //Dreadnaught
				AnarchulesBeetleBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.FireFrostVase>().AddIngredient(VitalityMod, "AnarchyCrystal").AddIngredient(VitalityMod, "AnarchyBar", 40).AddIngredient(ItemID.VileMushroom, 20).AddIngredient(ItemID.Deathweed, 5).AddIngredient(VitalityMod, "AnarchulesBeetleMask").AddTile(TileID.DemonAltar).Register(); //Anarchules Beetle
				ChaosbringerBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.FireFrostVase>().AddIngredient(VitalityMod, "TotemofChaos").AddIngredient(VitalityMod, "ChaosBar", 40).AddIngredient(VitalityMod, "ChaosCrystal", 100).AddIngredient(ItemID.ChaosFish).AddIngredient(ItemID.Blinkroot, 3).AddIngredient(VitalityMod, "ChaosbringerMask").AddTile(TileID.DemonAltar).Register(); //Chaosbringer
				PaladinSpiritBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.VitalityModItems.FireFrostVase>().AddIngredient(VitalityMod, "SpiritBox").AddIngredient(VitalityMod, "EquityCore").AddIngredient(VitalityMod, "SoulofVitality", 40).AddIngredient(VitalityMod, "Ectosoul", 25).AddIngredient(ItemID.Moonglow, 5).AddIngredient(VitalityMod, "PaladinSpiritMask").AddTile(TileID.DemonAltar).Register(); //Paladin Spirit
		
			}
		}
	}
}