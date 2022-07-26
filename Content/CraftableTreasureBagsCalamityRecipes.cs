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
	public class CraftableTreasureBagsCalamityRecipes : ModSystem
	{

		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("CalamityMod", out var CalamityMod)) return;
			{
				if (!ModContent.TryFind("CalamityMod/DesertScourgeBag", out ModItem DesertScourgeBag)) return; //CalamityMod
			/*	if (!ModContent.TryFind("CalamityMod/FortressBossBag", out ModItem FortressBossBag)) return; //CalamityMod
				if (!ModContent.TryFind("CalamityMod/AncientMachineBag", out ModItem AncientMachineBag)) return; //CalamityMod
				if (!ModContent.TryFind("CalamityMod/NoehtnapBag", out ModItem NoehtnapBag)) return; //CalamityMod
				if (!ModContent.TryFind("CalamityMod/HydraBag", out ModItem HydraBag)) return; //CalamityMod
				if (!ModContent.TryFind("CalamityMod/BladeBossBag", out ModItem BladeBossBag)) return; //CalamityMod
				if (!ModContent.TryFind("CalamityMod/RuneGhostBag", out ModItem RuneGhostBag)) return; //CalamityMod
				if (!ModContent.TryFind("CalamityMod/B4Bag", out ModItem B4Bag)) return; //CalamityMod
			*/
				DesertScourgeBag.CreateRecipe()
				.AddIngredient<Items.EmptyTreasureBag>()
				.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant")
				.AddIngredient(CalamityMod, "DesertMedallion")
				.AddIngredient(CalamityMod, "SeaRemains", 5)
				.AddIngredient(CalamityMod, "VictoryShard", 5)
				.AddIngredient(ItemID.SandBlock, 30)
				.AddIngredient(CalamityMod, "KnowledgeDesertScourge")
				.AddIngredient(CalamityMod, "DesertScourgeMask")
				.AddTile(TileID.DemonAltar)
				.Register(); //Desert Scourge

			/*	FortressBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Fortress Artifact").AddIngredient(QwertyMod, "FortressBossSummon").AddIngredient(QwertyMod, "CaeliteBar", 16).AddIngredient(QwertyMod, "CaeliteCore", 8).AddIngredient(QwertyMod, "FortressBrick", 50).AddIngredient(QwertyMod, "DivineLightMask").AddTile(26).Register(); //The Divine Light
				AncientMachineBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Fortress Artifact").AddIngredient(QwertyMod, "AncientEmblem", 1).AddIngredient(180, 20).AddIngredient(999, 10).AddIngredient(315, 3).AddIngredient(QwertyMod, "AncientMachineTrophy").AddTile(26).Register(); //Ancient Machine
				NoehtnapBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Fortress Artifact").AddIngredient(QwertyMod, "RitualInterupter", 3).AddIngredient(QwertyMod, "Etims", 50).AddIngredient(QwertyMod, "Reverseand", 50).AddIngredient(315, 3).AddTile(26).Register(); // Noehtnap
																																																																																		   // Hardmode Recipes Start Here
				HydraBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.QwertyModItems.MoonlightFortressArtifact>().AddIngredient(QwertyMod, "HydraSummon", 3).AddIngredient(QwertyMod, "HydraScale", 50).AddIngredient(QwertyMod, "LuneBar", 20).AddIngredient(316, 5).AddIngredient(QwertyMod, "HydraTrophy").AddTile(26).Register(); //The Hydra
				BladeBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.QwertyModItems.MoonlightFortressArtifact>().AddIngredient(QwertyMod, "BladeBossSummon").AddIngredient(QwertyMod, "CaeliteBar", 10).AddIngredient(QwertyMod, "LuneBar", 15).AddIngredient(QwertyMod, "FortressBrick", 20).AddIngredient(314, 3).AddIngredient(QwertyMod, "BladeBossTrophy").AddTile(26).Register(); //Imperious
				RuneGhostBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.QwertyModItems.MoonlightFortressArtifact>().AddIngredient(QwertyMod, "SummoningRune").AddIngredient(QwertyMod, "CraftingRune", 30).AddIngredient(1508, 30).AddIngredient(315, 5).AddIngredient(314, 5).AddIngredient(QwertyMod, "RuneGhostMask").AddTile(26).Register(); //Rune Ghost
				B4Bag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddIngredient<Items.QwertyModItems.MoonlightFortressArtifact>().AddIngredient(QwertyMod, "B4Summon", 3).AddIngredient(QwertyMod, "RhuthiniumBar", 30).AddIngredient(315, 3).AddIngredient(316, 3).AddTile(26).Register(); //O.L.O.R.D
			*/
			}
		}
	}
}