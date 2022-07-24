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
	public class CraftableTreasureBagsExpandWeaponsRecipes : ModSystem
	{
		Mod summonWhips = ModLoader.GetMod("SummonWhips");
		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("ExpandedWeapons", out var ExpandedWeapons)) return;
			{
				if (!ModContent.TryFind("ExpandedWeapons/CloudBossBag", out ModItem CloudBossBag)) return; //ExpandedWeapons
				ModLoader.TryGetMod("SummonWhips", out Mod summonWhips);
				Recipe recipe = CloudBossBag.CreateRecipe();
				recipe.AddIngredient<Items.EmptyTreasureBag>();
				recipe.AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant");
				recipe.AddIngredient(ExpandedWeapons, "StrangeCloud", 1);
				recipe.AddIngredient(ItemID.Cloud, 50);
				recipe.AddIngredient(ItemID.RainCloud, 30);
				if (ModLoader.TryGetMod("SummonWhips", out var SummonWhips))
				{
					recipe.AddIngredient(SummonWhips, "RainbowEssence", 12);
				}
				recipe.AddIngredient(ExpandedWeapons, "CloudHandle");
				recipe.AddIngredient(ExpandedWeapons, "ChargedCloud");
				recipe.AddIngredient(ExpandedWeapons, "CloudMask");
				recipe.AddTile(TileID.DemonAltar);
				recipe.Register(); //Cloud Boss
			}
		}
	}
}