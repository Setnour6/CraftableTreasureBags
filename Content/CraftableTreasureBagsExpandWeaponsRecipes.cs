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

		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("ExpandedWeapons", out var ExpandedWeapons)) return;
			{
				if (!ModContent.TryFind("ExpandedWeapons/CloudBossBag", out ModItem CloudBossBag)) return; //ExpandedWeapons

				CloudBossBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant")
					.AddIngredient(ExpandedWeapons, "StrangeCloud", 1)
					.AddIngredient(751, 50)
					.AddIngredient(765, 30)
					.AddIngredient(ExpandedWeapons, "RainbowEssence", 12)
					.AddIngredient(ExpandedWeapons, "CloudHandle")
					.AddIngredient(ExpandedWeapons, "ChargedCloud")
					.AddIngredient(ExpandedWeapons, "CloudMask")
					.AddTile(26)
					.Register(); //Cloud Boss
			}
		
		}
	}
}