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

namespace CraftableTreasureBags.Items.VitalityModItems
{
	public class PureVase : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pure Vase");
			Tooltip.SetDefault("Not Equippable"
				+ $"\nUsed to make boss treasure bags from the [c/6E8CB4:Vitality Mod]"
				+ $"\n'It has that fresh jungle smell'");
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Czysty Wazon");
			Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Nie mozna zalozyc"
				+ $"\nUzywany do tworzenia toreb na skarby bossow z [c/6E8CB4:Vitality Mod]"
				+ $"\n'To ma ten swiezy zapach dzungli'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 5;
		}

		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 50;
			Item.maxStack = 99;
			Item.value = 1000;
			Item.rare = ItemRarityID.White;
		}

		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("VitalityMod", out var VitalityMod)) return;
			CreateRecipe()
			.AddIngredient(VitalityMod, "PurifiedBar", 2)
			.AddIngredient(VitalityMod, "SteelAlloy", 1)
			.AddIngredient(331, 1)
			.AddTile(16)
			.Register();
		}
	}
}
