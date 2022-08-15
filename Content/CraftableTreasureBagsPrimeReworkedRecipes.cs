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
	public class CraftableTreasureBagsPrimeReworkedRecipes : ModSystem
	{

		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("PrimeRework", out var PrimeRework)) return;
			{
				if (!ModContent.TryFind("PrimeRework/TerminatorBossBag", out ModItem TerminatorBossBag)) return; //PrimeRework

				TerminatorBossBag.CreateRecipe()
				.AddIngredient<Items.EmptyTreasureBag>()
				.AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant")
				.AddIngredient(PrimeRework, "BrainRemote", 1)
				.AddIngredient(ItemID.SoulofMight, 40)
				.AddIngredient(ItemID.HallowedBar, 30)
				.AddIngredient(ItemID.Cog, 50)
				.AddIngredient(PrimeRework, "TerminatorMask")
				.AddTile(TileID.DemonAltar)
				.Register(); //The Terminator
			}

		}
	}
}