using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace terralord.items.Bars
{
    public class NightmareOre : ModItem
    {
        public override void SetDefaults()
        {

            item.createTile = mod.TileType("NightmareOre");
            item.consumable = true;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.useTime = 20;
            item.maxStack = 999;
            item.autoReuse = true;
        }
    }
}
