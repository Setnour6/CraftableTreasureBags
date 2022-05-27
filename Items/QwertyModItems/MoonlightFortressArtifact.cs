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
	public class MoonlightFortressArtifact : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonlight Artifact");
			Tooltip.SetDefault("Not Equippable"
				+ $"\nUsed to make hardmode boss treasure bags from [c/6E8CB4:Qwerty's Bosses and Items] Mod"
				+ $"\n'This lunic box thing looks like it could dominate the stock market'");
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Artefakt blasku ksiezyca");
			Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Nie mozna zalozyc"
				+ $"\nUzywany do tworzenia hardmodowych toreb na skarby bossow z [c/6E8CB4:Qwerty's Bosses and Items] Mod"
				+ $"\n'Te luniczne pudelko wyglada jak cos co moglo zdominowac rynek'");
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

		public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
		{
			Texture2D texture = Request<Texture2D>("CraftableTreasureBags/Items/QwertyModItems/MoonlightFortressArtifact_Glow").Value;
			spriteBatch.Draw
			(
				texture,
				new Vector2
				(
					Item.position.X - Main.screenPosition.X + Item.width * 0.5f,
					Item.position.Y - Main.screenPosition.Y + Item.height - texture.Height * 0.5f + 2f
				),
				new Rectangle(0, 0, texture.Width, texture.Height),
				Color.White,
				rotation,
				texture.Size() * 0.5f,
				scale,
				SpriteEffects.None,
				0f
			);
		}

		public override void AddRecipes()
		{
			if (!ModLoader.TryGetMod("QwertyMod", out var QwertyMod)) return;
			
			CreateRecipe()
			.AddIngredient(QwertyMod, "FortressBrick", 20)
			.AddRecipeGroup("CraftableTreasureBags:Gold/Platinum Fortress Artifact")
			.AddIngredient(520, 5)
			.AddIngredient(521, 10)
			.AddIngredient(QwertyMod, "LuneBar")
			.AddTile(134)
			.Register();

			CreateRecipe()
			.AddIngredient(QwertyMod, "FortressBrick", 30)
			.AddIngredient(520, 5)
			.AddIngredient(521, 10)
			.AddIngredient(QwertyMod, "LuneBar", 2)
			.AddIngredient(QwertyMod, "EnchantedWhetstone")
			.AddTile(134)
			.Register();

		}
	}
}
