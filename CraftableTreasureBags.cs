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
	public class CraftableTreasureBags : Mod
	{

		public override void AddRecipes()
		{
			
			#region Vanilla Boss Treasure Bags
			((Mod)this).CreateRecipe(ItemID.KingSlimeBossBag, 1)
			.AddIngredient<Items.EmptyTreasureBag>()
			.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant")
			.AddIngredient(ItemID.SlimeCrown, 1)
			.AddIngredient(ItemID.Gel, 400)
			.AddIngredient(ItemID.Blinkroot, 2)
			.AddIngredient(ItemID.KingSlimeMask, 1)
			.AddTile(TileID.DemonAltar)
			.Register();

			CreateRecipe(3319).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(ItemID.SuspiciousLookingEye, 1).AddIngredient(ItemID.BlackLens, 1).AddIngredient(ItemID.DemoniteOre, 90).AddIngredient(ItemID.Deathweed, 3).AddIngredient(ItemID.EyeMask, 1).AddTile(TileID.DemonAltar).Register(); //EOC (corruption)
			CreateRecipe(3319).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(ItemID.SuspiciousLookingEye, 1).AddIngredient(ItemID.BlackLens, 1).AddIngredient(ItemID.CrimtaneOre, 90).AddIngredient(ItemID.Deathweed, 3).AddIngredient(ItemID.EyeMask, 1).AddTile(TileID.DemonAltar).Register(); //EOC (crimson)
			CreateRecipe(3320).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(70, 1).AddIngredient(56, 300).AddIngredient(86, 150).AddIngredient(316, 5).AddIngredient(315, 3).AddIngredient(2111, 1).AddTile(26).Register(); //EOW
			CreateRecipe(3321).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(1331, 1).AddIngredient(880, 300).AddIngredient(1329, 150).AddIngredient(316, 5).AddIngredient(315, 3).AddIngredient(2104, 1).AddTile(26).Register(); //BOC
			CreateRecipe(3322).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(1133, 1).AddIngredient(2431, 26).AddIngredient(1134, 15).AddIngredient(209, 5).AddIngredient(1125, 10).AddIngredient(2108, 1).AddTile(26).Register(); //Queen Bee
			CreateRecipe(3323).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(1307, 1).AddIngredient(154, 250).AddIngredient(327, 3).AddIngredient(1274, 1).AddIngredient(1281, 1).AddTile(TileID.DemonAltar).Register(); //Skeletron
			CreateRecipe(3323).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(148, 3).AddIngredient(154, 500).AddIngredient(149, 20).AddIngredient(327, 5).AddIngredient(1452, 1).AddIngredient(5041, 1).AddIngredient(1274, 1).AddIngredient(1281, 1).AddTile(26).AddCondition(Recipe.Condition.TimeNight).Register(); //Skeletron //Recipe.Condition.TimeNight means the time should be night in order for this recipe to be usable for crafting.
            CreateRecipe(5111).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(5120, 1).AddIngredient(593, 50).AddIngredient(664, 50).AddIngredient(2358, 5).AddIngredient(315, 1).AddIngredient(5109, 1).AddTile(26).Register(); //Deerclops
                                                                                                                                                                                                                                                                                                      // Hardmode Recipes Start Here
            CreateRecipe(4957).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(4988, 1).AddIngredient(23, 500).AddIngredient(4758, 1).AddIngredient(315, 3).AddIngredient(4959, 1).AddTile(26).Register(); //Queen Slime
			CreateRecipe(3326).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(544, 1).AddIngredient(549, 40).AddIngredient(1225, 30).AddIngredient(1344, 50).AddIngredient(2106, 1).AddTile(26).Register(); //Twins
			CreateRecipe(3325).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(556, 1).AddIngredient(548, 40).AddIngredient(1225, 30).AddIngredient(1344, 50).AddIngredient(2113, 1).AddTile(26).Register(); //Destroyer
			CreateRecipe(3327).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(557, 1).AddIngredient(547, 40).AddIngredient(1225, 30).AddIngredient(1344, 50).AddIngredient(2107, 1).AddTile(26).Register(); //SPrime
			CreateRecipe(3328).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(1141, 1).AddIngredient(1157, 1).AddIngredient(1158, 1).AddIngredient(947, 50).AddIngredient(4241, 20).AddIngredient(313, 5).AddIngredient(314, 3).AddIngredient(2109, 1).AddTile(26).Register(); //Plantera
			CreateRecipe(3329).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(1293, 3).AddIngredient(2218, 15).AddIngredient(2767, 1).AddIngredient(1101, 25).AddIngredient(2110, 1).AddTile(26).Register(); //Golem
			CreateRecipe(3330).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(2673, 1).AddIngredient(3532, 2).AddIngredient(314, 3).AddIngredient(317, 5).AddIngredient(2588, 1).AddTile(26).Register(); //Duke Fishron
			CreateRecipe(4782).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(4961, 1).AddIngredient(502, 100).AddIngredient(520, 50).AddIngredient(4623, 1).AddIngredient(4778, 1).AddIngredient(501, 200).AddIngredient(526, 10).AddIngredient(315, 5).AddIngredient(314, 5).AddIngredient(4784, 1).AddTile(26).Register(); //Empress of Light
			CreateRecipe(3332).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(3601, 1).AddIngredient(3460, 100).AddIngredient(3384, 1).AddIngredient(4022, 1).AddIngredient(5044, 1).AddIngredient(315, 5).AddIngredient(314, 10).AddIngredient(3373, 1).AddTile(26).Register(); //Moon Lord
			// Event Recipes Start Here
			CreateRecipe(3860).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(3828, 1).AddIngredient(3817, 25).AddIngredient(3857, 1).AddIngredient(3819, 1).AddIngredient(318, 10).AddIngredient(3863, 1).AddTile(26).Register(); //Betsy, Old One's Army
			#endregion Vanilla boss treasure bags

		}
        public override void PostAddRecipes()
		{
			for (int i = 0; i < Recipe.numRecipes; i++)
			{
				Recipe recipe = Main.recipe[i];

			}
		}
	}
}