using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace terralord.items.material
{
    public class Cursedfragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("cursed fragment");
            Tooltip.SetDefault("basic cursed material");
        }
        public override void SetDefaults()
        {
            item.maxStack = 99;
            item.material = true;
            item.scale = 0.25f;
        }
    }
}
