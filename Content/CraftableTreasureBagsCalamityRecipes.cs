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
					if (!ModContent.TryFind("CalamityMod/CrabulonBag", out ModItem CrabulonBag)) return; //CalamityMod
					if (!ModContent.TryFind("CalamityMod/HiveMindBag", out ModItem HiveMindBag)) return; //CalamityMod
					if (!ModContent.TryFind("CalamityMod/PerforatorBag", out ModItem PerforatorBag)) return; //CalamityMod
					if (!ModContent.TryFind("CalamityMod/SlimeGodBag", out ModItem SlimeGodBag)) return; //CalamityMod
					// HARDMODE
					if (!ModContent.TryFind("CalamityMod/CryogenBag", out ModItem CryogenBag)) return; //CalamityMod
					if (!ModContent.TryFind("CalamityMod/AquaticScourgeBag", out ModItem AquaticScourgeBag)) return; //CalamityMod
					if (!ModContent.TryFind("CalamityMod/BrimstoneWaifuBag", out ModItem BrimstoneWaifuBag)) return; //CalamityMod
					if (!ModContent.TryFind("CalamityMod/CalamitasBag", out ModItem CalamitasBag)) return; //CalamityMod
				
				DesertScourgeBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant")
					.AddIngredient(CalamityMod, "DesertMedallion")
					.AddIngredient(CalamityMod, "SeaRemains", 5)
					.AddIngredient(CalamityMod, "VictoryShard", 5)
					.AddIngredient(ItemID.SandBlock, 30)
					.AddIngredient(CalamityMod, "DesertScourgeMask")
					.AddIngredient(CalamityMod, "KnowledgeDesertScourge")
					.AddTile(TileID.DemonAltar)
					.Register(); //Desert Scourge

				CrabulonBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant")
					.AddIngredient(CalamityMod, "DecapoditaSprout")
					.AddIngredient(ItemID.GlowingMushroom, 75)
					.AddIngredient(ItemID.MushroomGrassSeeds, 10)
					.AddIngredient(CalamityMod, "FungalClump")
					.AddIngredient(CalamityMod, "CrabulonMask")
					.AddIngredient(CalamityMod, "KnowledgeCrabulon")
					.AddTile(TileID.DemonAltar)
					.Register(); //Crabulon

				HiveMindBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant")
					.AddIngredient(CalamityMod, "Teratoma")
					.AddIngredient(CalamityMod, "RottenMatter", 30)
					.AddIngredient(ItemID.RottenChunk, 20)
					.AddIngredient(ItemID.DemoniteBar, 15)
					.AddIngredient(ItemID.CorruptSeeds, 15)
					.AddIngredient(CalamityMod, "RottenBrain")
					.AddIngredient(CalamityMod, "HiveMindMask")
					.AddIngredient(CalamityMod, "KnowledgeHiveMind")
					.AddTile(TileID.DemonAltar)
					.Register(); //The Hive Mind

				PerforatorBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant")
					.AddIngredient(CalamityMod, "BloodyWormFood")
					.AddIngredient(CalamityMod, "BloodSample", 30)
					.AddIngredient(ItemID.Vertebrae, 20)
					.AddIngredient(ItemID.CrimtaneBar, 15)
					.AddIngredient(ItemID.CrimsonSeeds, 15)
					.AddIngredient(CalamityMod, "BloodyWormTooth")
					.AddIngredient(CalamityMod, "PerforatorMask")
					.AddIngredient(CalamityMod, "KnowledgePerforators")
					.AddTile(TileID.DemonAltar)
					.Register(); //The Perforators

				SlimeGodBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant")
					.AddIngredient(CalamityMod, "OverloadedSludge")
					.AddIngredient(CalamityMod, "PurifiedGel", 45)
					.AddIngredient(ItemID.Gel, 500)
					.AddIngredient(CalamityMod, "ManaPolarizer")
					.AddIngredient(CalamityMod, "SlimeGodMask")
					.AddIngredient(CalamityMod, "KnowledgeSlimeGod")
					.AddTile(TileID.DemonAltar)
					.Register(); //The Slime God (Corruption Mask)

				SlimeGodBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant")
					.AddIngredient(CalamityMod, "OverloadedSludge")
					.AddIngredient(CalamityMod, "PurifiedGel", 45)
					.AddIngredient(ItemID.Gel, 500)
					.AddIngredient(CalamityMod, "ManaPolarizer")
					.AddIngredient(CalamityMod, "SlimeGodMask2")
					.AddIngredient(CalamityMod, "KnowledgeSlimeGod")
					.AddTile(TileID.DemonAltar)
					.Register(); //The Slime God (Crimson Mask)

				// HARDMODE RECIPES BEGIN HERE

				CryogenBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant")
					.AddIngredient(CalamityMod, "CryoKey")
					.AddIngredient(CalamityMod, "EssenceofEleum", 8)
					.AddIngredient(ItemID.FrostCore, 3)
					.AddIngredient(ItemID.IceBlock, 50)
					.AddIngredient(CalamityMod, "SoulofCryogen")
					.AddIngredient(CalamityMod, "CryogenMask")
					.AddIngredient(CalamityMod, "KnowledgeCryogen")
					.AddTile(TileID.DemonAltar)
					.Register(); //Cryogen

				AquaticScourgeBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant")
					.AddIngredient(CalamityMod, "Seafood")
					.AddIngredient(CalamityMod, "BleachedAnglingKit", 1)
					.AddIngredient(CalamityMod, "SulphurousSand", 50)
					.AddIngredient(CalamityMod, "AquaticEmblem")
					.AddIngredient(CalamityMod, "AquaticScourgeMask")
					.AddIngredient(CalamityMod, "KnowledgeAquaticScourge")
					.AddTile(TileID.DemonAltar)
					.Register(); //Aquatic Scourge

				BrimstoneWaifuBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant")
					.AddIngredient(CalamityMod, "CharredIdol")
					.AddIngredient(CalamityMod, "EssenceofChaos", 8)
					.AddIngredient(CalamityMod, "BrimstoneSlag", 50)
					.AddIngredient(CalamityMod, "Gehenna")
					.AddIngredient(CalamityMod, "Abaddon")
					.AddIngredient(CalamityMod, "BrimstoneWaifuMask")
					.AddIngredient(CalamityMod, "KnowledgeBrimstoneElemental")
					.AddTile(TileID.DemonAltar)
					.Register(); //Brimstone Elemental

				CalamitasBag.CreateRecipe()
					.AddIngredient<Items.EmptyTreasureBag>()
					.AddRecipeGroup("CraftableTreasureBags:Adamantite/Titanium Pendant")
					.AddIngredient(CalamityMod, "EyeofDesolation")
					.AddIngredient(CalamityMod, "EssenceofChaos", 8)
					.AddIngredient(CalamityMod, "AshesofCalamity", 14)
					.AddIngredient(ItemID.BrokenHeroSword)
					.AddIngredient(CalamityMod, "VoidofCalamity")
					.AddIngredient(CalamityMod, "CalamitasMask")
					.AddIngredient(CalamityMod, "KnowledgeCalamitasClone")
					.AddTile(TileID.DemonAltar)
					.Register(); //Calamitas
			}
		}
		public override void PostAddRecipes()
		{
			if (ModLoader.TryGetMod("CalamityMod", out Mod CalamityMod))
			for (int i = 0; i < Recipe.numRecipes; i++)
			{
				Recipe recipe = Main.recipe[i];
                #region vanilla knowledge ingredient add
                if (recipe.HasIngredient(ItemID.KingSlimeMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeKingSlime");
				if (recipe.HasIngredient(ItemID.EyeMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeEyeofCthulhu");
				if (recipe.HasIngredient(ItemID.EaterMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeEaterofWorlds");
				if (recipe.HasIngredient(ItemID.BrainMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeBrainofCthulhu");
				if (recipe.HasIngredient(ItemID.BeeMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeQueenBee");
				if (recipe.HasIngredient(ItemID.SkeletronMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeSkeletron");
		//		if (recipe.HasIngredient(ItemID.DeerclopsMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
		//			recipe.AddIngredient(CalamityMod, "KnowledgeDeerclops");
		//		if (recipe.HasIngredient(ItemID.QueenSlimeMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
		//			recipe.AddIngredient(CalamityMod, "KnowledgeQueenSlime");
				if (recipe.HasIngredient(ItemID.TwinMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeTwins");
				if (recipe.HasIngredient(ItemID.DestroyerMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeDestroyer");
				if (recipe.HasIngredient(ItemID.SkeletronPrimeMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeSkeletronPrime");
				if (recipe.HasIngredient(ItemID.PlanteraMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgePlantera");
				if (recipe.HasIngredient(ItemID.GolemMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeGolem");
				if (recipe.HasIngredient(ItemID.DukeFishronMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeDukeFishron");
		//		if (recipe.HasIngredient(ItemID.FairyQueenMask) && recipe.HasIngredient<Items.EmptyTreasureBag>())
		//			recipe.AddIngredient(CalamityMod, "KnowledgeEmpressofLight");
				if (recipe.HasIngredient(ItemID.BossMaskCultist) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeLunaticCultist");
				if (recipe.HasIngredient(ItemID.BossMaskMoonlord) && recipe.HasIngredient<Items.EmptyTreasureBag>())
					recipe.AddIngredient(CalamityMod, "KnowledgeMoonLord");
				#endregion

				#region calamity knowledge ingredient add
				#endregion
			}
        }
	}
}