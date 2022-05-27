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
using ReLogic.Content;
using Terraria.Audio;

namespace CraftableTreasureBags.Items.MechBossReworkItems
{
	public class MechanicalLED : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mechanical LED");
			Tooltip.SetDefault("Dropped from the Three Mechanical Bosses"
				+ $"\nUsed to make hardmode boss treasure bags from the [c/6E8CB4:Mech Bosses Reworked] Mod"
				+ $"\n'This LED is so advanced, it can stay on for eternity'");
			DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Mechaniczna Dioda");
			Tooltip.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Trzy mechaniczne bossy po smierci wyrzucaja ten przedmiot"
				+ $"\nUzywany do tworzenia hardmodowych toreb na skarby bossow z [c/6E8CB4:Mech Bosses Reworked] Mod"
				+ $"\n'Ta dioda jest tak zaawansowana, ze moze wiecznie zostac'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 5;
		}

		public override void SetDefaults()
		{
			Item.width = 10;
			Item.height = 22;
			Item.maxStack = 99;
			Item.value = 1000;
			Item.rare = ItemRarityID.Orange;
		}

		public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
		{
			Texture2D texture = Request<Texture2D>("CraftableTreasureBags/Items/MechBossReworkItems/MechanicalLED_Glow").Value;
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

		//	public override void AddRecipes()
		//	{
		//		CreateRecipe()
		//		.AddIngredient(597, 1)
		//		.AddRecipeGroup(RecipeGroupID.IronBar, 1)
		//		.AddIngredient(1225, 1)
		//		.AddTile(134)
		//		.Register();
		//	}
	}
}
