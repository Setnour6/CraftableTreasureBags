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

		
	}
}