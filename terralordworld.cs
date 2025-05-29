using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;
using System.Security.AccessControl;
using Terraria.IO;
using Terraria.ModLoader.IO;
using System.IO;

namespace terralord
{ 
    public class Terralordworld : ModWorld
    {
        public static bool DownedSlimeFactory = false;

        public override void Initialize()
        {
            DownedSlimeFactory = false;
        }

        public override TagCompound Save()
        {
            var Downed = new List<string>();
            if (DownedSlimeFactory) Downed.Add("SlimeFactory");

            return new TagCompound
            {
                {
                    "version", 0
                },
                {
                    "Downed", Downed
                }
            };
        }

        public override void Load(TagCompound tag)
        {
            var Downed = tag.GetList<string>("Downed");
            DownedSlimeFactory = Downed.Contains("SlimeFactory");
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if (loadVersion == 0)
            {
                BitsByte flags = reader.ReadByte();
                DownedSlimeFactory = flags[0];
            }
        }

        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = DownedSlimeFactory;

            writer.Write(flags);
        }
        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            DownedSlimeFactory = flags[0];
        }
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(x => x.Name.Equals("Shinies"));
            if (shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("Terralords Ore Generation", OreGeneration));
            }
        }

        private void OreGeneration(GenerationProgress progress)
        {
            progress.Message = "Terralords Mod Ores";

            for (var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);

                WorldGen.TileRunner(x,
                    y,
                    (double)WorldGen.genRand.Next(4, 7),
                    WorldGen.genRand.Next(4, 7),
                    mod.TileType("CoalOre"),
                    false,
                    0f,
                    0f,
                    false,
                    true);


            }

            int count = 0;

            while (count < 1)
            {
                for (var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                {
                    int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                    int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);
                    Tile tile = Framing.GetTileSafely(x, y);
                    if (tile.active() && (tile.type == TileID.Stone || tile.type == TileID.Dirt))
                    {
                        WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(4, 7), WorldGen.genRand.Next(4, 7), mod.TileType("CoalOre"));
                        count++;
                    }
                }
                for (var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                {
                    int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                    int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);
                    Tile tile = Framing.GetTileSafely(x, y);
                    if (tile.active() && (tile.type == TileID.Stone || tile.type == TileID.Dirt))
                    {
                        WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(4, 7), WorldGen.genRand.Next(4, 7), mod.TileType("NightmareOre"));
                        count++;
                    }
                }
            }
        }
    }
}