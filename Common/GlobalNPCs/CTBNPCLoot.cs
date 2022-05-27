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

namespace CraftableTreasureBags.Common.GlobalNPCs
{
	class CTBNPCLoot : GlobalNPC
	{
//		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
//		{
//			if (npc.type == NPCID.Retinazer && !NPC.AnyNPCs(NPCID.Spazmatism) || npc.type == NPCID.Spazmatism && !NPC.AnyNPCs(NPCID.Retinazer))
//			{
//				//Item.NewItem(npc.getRect(), ModContent.ItemType<Items.MechBossRewardsItems.MechanicalLED>, Main.rand.Next(10, 21));
//				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.MechBossReworkItems.MechanicalLED>(), 1, 1 + Main.rand.Next(1)));
//			}
//			if (npc.type == NPCID.SkeletronPrime)
//			{
//				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.MechBossReworkItems.MechanicalLED>(), 1, 2 + Main.rand.Next(1)));
//			}
//			if (npc.boss && System.Array.IndexOf(new int[] { NPCID.TheDestroyerBody, NPCID.TheDestroyer, NPCID.TheDestroyerTail }, npc.type) > -1)
//			{
//				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.MechBossReworkItems.MechanicalLED>(), 1, 2 + Main.rand.Next(1)));
//			}
		//	if (!ModLoader.TryGetMod("PrimeRework", out var PrimeRework)) return;
		//	{
		//		if (!ModContent.TryFind("PrimeRework/TheTerminator", out ModNPC TheTerminator))
		//		{
		//			if (npc.type == (PrimeRework, TheTerminator))
		//			{
		//				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.MechBossReworkItems.MechanicalLED>(), Main.rand.Next(5, 11)));
		//			}
		//		}
		//	}
//		}
	}
}