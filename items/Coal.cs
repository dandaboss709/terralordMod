using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace terralord.items       
{
    public class Coal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Coal");
            Tooltip.SetDefault("black and full of carbon");
        }
        public override void SetDefaults()
        {
            item.createTile = mod.TileType("CoalOre");
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.consumable = true;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.autoReuse = true;
        }
    }
}
