using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace terralord.items.Bars
{
    public class ColdSteelBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cold Steel bar");
            Tooltip.SetDefault("Frozen");
        }
        public override void SetDefaults()
        {
            item.maxStack = 99;
            item.value = 1000000;
        }
    }
}
