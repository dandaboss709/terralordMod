using System;
using System.Collections.Generic;
using terralord.Tiles;
using Terraria.ModLoader;

namespace terralord
{
    public class terralord : Mod
    {
        public override void PostSetupContent()
        {

            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if (bossChecklist != null)
            {
                 bossChecklist.Call("AddBoss", 3f, NPCType("Slime Factory"), this, "Slime Factory", (Func<bool>)(() => Terralordworld.DownedSlimeFactory), ItemType("SlimyComponents"), new List<int> { }, new List<int> (), "Use a [i:" + ItemType("SlimyComponents;") + "] at any time.");
            }
        }
    }
}