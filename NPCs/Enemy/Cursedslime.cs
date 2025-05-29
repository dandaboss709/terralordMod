using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.Modules;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace terralord.NPCs.Enemy
{
    public class Cursedslime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 2;
        }
        public override void SetDefaults()
        {
            npc.lifeMax = 350;
            npc.aiStyle = 1;
            npc.damage = 10;
            npc.defense = 6;
            npc.width = 46;
            npc.height = 32;
            animationType = NPCID.BlueSlime;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 100;
            npc.knockBackResist = -2f;

        }




        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.dayTime)
            {
                return spawnInfo.player.ZoneOverworldHeight ? 0.1f : 0f;
            }
            else
            {
                return 0f;
            }
        }
        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("Cursedfragment"), Main.rand.Next(1, 2));

            Item.NewItem(npc.getRect(), ItemID.Gel, Main.rand.Next(1, 4));
        }

    }
}
