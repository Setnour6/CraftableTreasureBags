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

namespace CraftableTreasureBags.Items.QwertyModItems
{
	public class GoldFortressArtifact : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fortress Artifact");
			Tooltip.SetDefault("Not Equippable"
				+ $"\nUsed to make boss treasure bags from [c/6E8CB4:Qwerty's Bosses and Items] Mod"
				+ $"\n'This golden box thing looks like it could sell for a fortune'");
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Fortecowy Artefakt");
			Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Nie mozna zalozyc"
				+ $"\nUzywany do tworzenia toreb na skarby bossow z [c/6E8CB4:Qwerty's Bosses and Items] Mod"
				+ $"\n'Te zlote pudelko wyglada na cos co mozna sprzedac za fortune'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 5;
		}

		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 50;
			Item.maxStack = 99;
			Item.value = 1000;
			Item.rare = ItemRarityID.Green;
		}

		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("QwertyMod", out var QwertyMod)) return;
			
			CreateRecipe()
			.AddIngredient(QwertyMod, "FortressBrick", 10)
			.AddIngredient(ItemID.GoldBar, 2)
			.AddIngredient(QwertyMod, "EnchantedWhetstone")
			.AddTile(TileID.Anvils)
			.Register();
		
		}
	}
}
