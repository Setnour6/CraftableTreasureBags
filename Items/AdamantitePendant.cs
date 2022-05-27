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

namespace CraftableTreasureBags.Items
{
	public class AdamantitePendant : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Pendant");
			Tooltip.SetDefault("Not Equippable"
				+ $"\nUsed to make hardmode boss treasure bags"
				+ $"\n'The chain is too small to fit around your neck, but you can still keep it as a souvenir'");
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Adamantytowy wisiorek");
			Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Nie mozna zalozyc"
				+ $"\nUzywany do tworzenia hardmodowych toreb na skarby bossow"
				+ $"\n'Lancuszek jest za maly aby zmiescil sie dookola twojej szyji, ale mozesz nadal go trzymac jako pamiatke'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 5;
		}

		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 50;
			Item.maxStack = 99;
			Item.value = 5000;
			Item.rare = ItemRarityID.Orange;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(391, 3)
			.AddIngredient(85, 2)
			.AddTile(134)
			.Register();

			CreateRecipe()
			.AddIngredient(366, 10)
			.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Pendant")
			.AddTile(134)
			.Register();
		}
	}
}
