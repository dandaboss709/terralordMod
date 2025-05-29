using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace terralord.NPCs.Enemy
{
    public class Cursedzombie : ModNPC
    {
        public override void SetStaticDefaults()
        {

            Main.npcFrameCount[npc.type] = 2;
        }
        public override void SetDefaults()
        {

            npc.lifeMax = 350;
            npc.aiStyle = 3;
            npc.damage = 10;
            npc.defense = 6;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 100;
            npc.knockBackResist = 0f;
            npc.scale = 1f;
            npc.behindTiles = false;
            npc.collideX = true;
            npc.collideY = true;
            npc.width = 34;
            npc.height = 46;

            animationType = NPCID.Zombie;
            banner = npc.type;
        }




        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (!Main.dayTime)
            {
                if (spawnInfo.player.ZoneOverworldHeight)
                {
                    return (SpawnCondition.OverworldNightMonster.Chance) * 0.2f;
                }
                else
                {
                    return 0f;
                }
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
