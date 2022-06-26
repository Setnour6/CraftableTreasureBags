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
	public class CraftableTreasureBagsMoreWhipsRecipes : ModSystem
	{

		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("SummonWhips", out var SummonWhips)) return;
			{
				if (!ModContent.TryFind("SummonWhips/MeteorBossBag", out ModItem MeteorBossBag)) return; //ExpandedWeapons
				if (!ModContent.TryFind("SummonWhips/SirVioletBossBag", out ModItem SirVioletBossBag)) return; //ExpandedWeapons

				MeteorBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(SummonWhips, "CelestialMeteor", 1).AddIngredient(SummonWhips, "MeteorCore", 2).AddIngredient(ItemID.MeteoriteBar, 15).AddIngredient(ItemID.FallenStar, 3).AddIngredient(SummonWhips, "MeteorShard", 2).AddIngredient(SummonWhips, "MeteorMask").AddTile(TileID.DemonAltar).Register(); //Corite Knight
				SirVioletBossBag.CreateRecipe().AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(SummonWhips, "VioletCrystal", 1).AddIngredient(SummonWhips, "MagicFragment", 12).AddIngredient(ItemID.VioletGradientDye).AddIngredient(SummonWhips, "MagicBottle", 1).AddIngredient(SummonWhips, "SirVioletMask").AddTile(TileID.DemonAltar).Register(); //Sir Violet
			}
		}
	}
}