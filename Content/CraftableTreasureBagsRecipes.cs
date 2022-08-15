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
	public class CraftableTreasureBagsRecipes : ModSystem
	{

		public static RecipeGroup CTBRecipeGroup;
		public static RecipeGroup CTBRecipeGroup2;
		public static RecipeGroup CTBQwertyModRecipeGroup;

		public override void Unload()
		{
			CTBRecipeGroup = null;
			CTBRecipeGroup2 = null;
			CTBQwertyModRecipeGroup = null;
		}
		public override void AddRecipeGroups()
		{
			// Create a recipe group and store it
			// Language.GetTextValue("LegacyMisc.37") is the word "Any" in english, and the corresponding word in other languages
			CTBRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ModContent.ItemType<Items.GoldPendant>())}",
				ModContent.ItemType<Items.GoldPendant>(), ModContent.ItemType<Items.PlatinumPendant>());
			RecipeGroup.RegisterGroup("CraftableTreasureBags:Gold/Platinum Pendant", CTBRecipeGroup);

			CTBRecipeGroup2 = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ModContent.ItemType<Items.AdamantitePendant>())}",
			ModContent.ItemType<Items.AdamantitePendant>(), ModContent.ItemType<Items.TitaniumPendant>());
			RecipeGroup.RegisterGroup("CraftableTreasureBags:Adamantite/Titanium Pendant", CTBRecipeGroup2);

			CTBQwertyModRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ModContent.ItemType<Items.QwertyModItems.GoldFortressArtifact>())}",
			ModContent.ItemType<Items.QwertyModItems.GoldFortressArtifact>(), ModContent.ItemType<Items.QwertyModItems.PlatinumFortressArtifact>());
			RecipeGroup.RegisterGroup("CraftableTreasureBags:Gold/Platinum Fortress Artifact", CTBQwertyModRecipeGroup);
		}
		public override void AddRecipes()
		{

			#region Vanilla Boss Treasure Bags
			Recipe recipe = Recipe.Create(ItemID.KingSlimeBossBag, 1);
			recipe.AddIngredient<Items.EmptyTreasureBag>();
			recipe.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant");
			recipe.AddIngredient(ItemID.SlimeCrown, 1);
			recipe.AddIngredient(ItemID.Gel, 400);
			recipe.AddIngredient(ItemID.Blinkroot, 2);
			/*	if (ModLoader.TryGetMod("CalamityMod", out Mod CalamityMod))
				{
					recipe.AddIngredient(CalamityMod, "KnowledgeKingSlime", 1);
				}
			*/
			recipe.AddIngredient(ItemID.KingSlimeMask, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register(); //King Slime

			recipe = Recipe.Create(ItemID.EyeOfCthulhuBossBag);
			recipe.AddIngredient<Items.EmptyTreasureBag>();
			recipe.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant");
			recipe.AddIngredient(ItemID.SuspiciousLookingEye, 1);
			recipe.AddIngredient(ItemID.BlackLens, 1);
			recipe.AddIngredient(ItemID.DemoniteOre, 90);
			recipe.AddIngredient(ItemID.Deathweed, 3);
			/*	if (ModLoader.TryGetMod("CalamityMod", out Mod CalamityMod1)) 
				{
					recipe.AddIngredient(CalamityMod, "KnowledgeEyeofCthulhu", 1);
				}
			*/
			recipe.AddIngredient(ItemID.EyeMask, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register(); //EOC (corruption)
			Recipe.Create(3319).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(ItemID.SuspiciousLookingEye, 1).AddIngredient(ItemID.BlackLens, 1).AddIngredient(ItemID.CrimtaneOre, 90).AddIngredient(ItemID.Deathweed, 3).AddIngredient(ItemID.EyeMask, 1).AddTile(TileID.DemonAltar).Register(); //EOC (crimson)
			Recipe.Create(3320).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(ItemID.WormFood, 1).AddIngredient(ItemID.DemoniteOre, 300).AddIngredient(ItemID.ShadowScale, 150).AddIngredient(ItemID.Deathweed, 5).AddIngredient(ItemID.Blinkroot, 3).AddIngredient(ItemID.EaterMask, 1).AddTile(TileID.DemonAltar).Register(); //EOW
			Recipe.Create(3321).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(ItemID.BloodySpine, 1).AddIngredient(ItemID.CrimtaneOre, 300).AddIngredient(ItemID.TissueSample, 150).AddIngredient(ItemID.Deathweed, 5).AddIngredient(ItemID.Blinkroot, 3).AddIngredient(ItemID.BrainMask, 1).AddTile(TileID.DemonAltar).Register(); //BOC
			Recipe.Create(3322).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(ItemID.Abeemination, 1).AddIngredient(ItemID.BeeWax, 26).AddIngredient(ItemID.BottledHoney, 15).AddIngredient(ItemID.Stinger, 5).AddIngredient(ItemID.HoneyBlock, 10).AddIngredient(ItemID.BeeMask, 1).AddTile(TileID.DemonAltar).Register(); //Queen Bee
			Recipe.Create(3323).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(ItemID.ClothierVoodooDoll, 1).AddIngredient(ItemID.Bone, 250).AddIngredient(ItemID.GoldenKey, 3).AddIngredient(ItemID.Skull, 1).AddIngredient(ItemID.SkeletronMask, 1).AddTile(TileID.DemonAltar).Register(); //Skeletron
			Recipe.Create(3323).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(ItemID.WaterCandle, 3).AddIngredient(ItemID.Bone, 500).AddIngredient(ItemID.Book, 20).AddIngredient(ItemID.GoldenKey, 5).AddIngredient(ItemID.NecromanticSign, 1).AddIngredient(ItemID.MilkCarton, 1).AddIngredient(ItemID.Skull, 1).AddIngredient(ItemID.SkeletronMask, 1).AddTile(TileID.DemonAltar).AddCondition(Recipe.Condition.TimeNight).Register(); //Skeletron //Recipe.Condition.TimeNight means the time should be night in order for this recipe to be usable for crafting.
			Recipe.Create(5111).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant").AddIngredient(ItemID.DeerThing, 1).AddIngredient(ItemID.SnowBlock, 25).AddIngredient(ItemID.IceBlock, 25).AddIngredient(ItemID.Shiverthorn, 5).AddIngredient(ItemID.Blinkroot, 3).AddIngredient(ItemID.DeerclopsMask, 1).AddTile(TileID.DemonAltar).Register(); //Deerclops
																																																																																																	  // Hardmode Recipes Start Here
			Recipe.Create(4957).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.QueenSlimeCrystal, 1).AddIngredient(ItemID.Gel, 500).AddIngredient(ItemID.Smolstar, 1).AddIngredient(ItemID.Blinkroot, 3).AddIngredient(ItemID.QueenSlimeMask, 1).AddTile(TileID.DemonAltar).Register(); //Queen Slime
			Recipe.Create(3326).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.MechanicalEye, 1).AddIngredient(ItemID.SoulofSight, 40).AddIngredient(ItemID.HallowedBar, 30).AddIngredient(ItemID.Cog, 50).AddIngredient(ItemID.TwinMask, 1).AddTile(TileID.DemonAltar).Register(); //Twins
			Recipe.Create(3325).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.MechanicalWorm, 1).AddIngredient(ItemID.SoulofMight, 40).AddIngredient(ItemID.HallowedBar, 30).AddIngredient(ItemID.Cog, 50).AddIngredient(ItemID.DestroyerMask, 1).AddTile(TileID.DemonAltar).Register(); //Destroyer
			Recipe.Create(3327).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.MechanicalSkull, 1).AddIngredient(ItemID.SoulofFright, 40).AddIngredient(ItemID.HallowedBar, 30).AddIngredient(ItemID.Cog, 50).AddIngredient(ItemID.SkeletronPrimeMask, 1).AddTile(TileID.DemonAltar).Register(); //SPrime
			Recipe.Create(3328).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.TempleKey, 1).AddIngredient(ItemID.PygmyStaff, 1).AddIngredient(ItemID.PygmyNecklace, 1).AddIngredient(ItemID.ChlorophyteOre, 50).AddIngredient(ItemID.FlowerPacketWild, 20).AddIngredient(ItemID.Daybloom, 5).AddIngredient(ItemID.Moonglow, 3).AddIngredient(ItemID.PlanteraMask, 1).AddTile(TileID.DemonAltar).Register(); //Plantera
			Recipe.Create(3329).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.LihzahrdPowerCell, 3).AddIngredient(ItemID.BeetleHusk, 15).AddIngredient(ItemID.SolarTablet, 1).AddIngredient(ItemID.LihzahrdBrick, 25).AddIngredient(ItemID.GolemMask, 1).AddTile(TileID.DemonAltar).Register(); //Golem
			Recipe.Create(3330).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.TruffleWorm, 1).AddIngredient(ItemID.Bacon, 2).AddIngredient(ItemID.Moonglow, 3).AddIngredient(ItemID.Waterleaf, 5).AddIngredient(ItemID.DukeFishronMask, 1).AddTile(TileID.DemonAltar).Register(); //Duke Fishron
			Recipe.Create(4782).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.EmpressButterfly, 1).AddIngredient(ItemID.CrystalShard, 100).AddIngredient(ItemID.SoulofLight, 50).AddIngredient(ItemID.PrismaticPunch, 1).AddIngredient(ItemID.HallowBossDye, 1).AddIngredient(ItemID.PixieDust, 200).AddIngredient(ItemID.UnicornHorn, 10).AddIngredient(ItemID.Blinkroot, 5).AddIngredient(ItemID.Moonglow, 5).AddIngredient(ItemID.FairyQueenMask, 1).AddTile(TileID.DemonAltar).Register(); //Empress of Light
			Recipe.Create(3332).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.CelestialSigil, 1).AddIngredient(ItemID.LunarOre, 100).AddIngredient(ItemID.PortalGun, 1).AddIngredient(ItemID.GoldenDelight, 1).AddIngredient(ItemID.MusicBoxCredits, 1).AddIngredient(ItemID.Blinkroot, 5).AddIngredient(ItemID.Moonglow, 10).AddIngredient(ItemID.BossMaskMoonlord, 1).AddTile(TileID.DemonAltar).Register(); //Moon Lord
																																																																																																																								  // Event Recipes Start Here
			Recipe.Create(3860).AddIngredient<Items.EmptyTreasureBag>().AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant").AddIngredient(ItemID.DD2ElderCrystal, 1).AddIngredient(ItemID.DefenderMedal, 25).AddIngredient(ItemID.DD2PetDragon, 1).AddIngredient(ItemID.DD2FlameburstTowerT2Popper, 1).AddIngredient(ItemID.Fireblossom, 10).AddIngredient(ItemID.BossMaskBetsy, 1).AddTile(TileID.DemonAltar).Register(); //Betsy, Old One's Army
			#endregion Vanilla boss treasure bags

		}
	/*	public override void PostAddRecipes()
		{
			for (int i = 0; i < Recipe.numRecipes; i++)
			{
				Recipe recipe = Main.recipe[i];

			}
		}
*/	}
}