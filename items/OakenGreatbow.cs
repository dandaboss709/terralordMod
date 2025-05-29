using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace terralord.items
{
    public class OakenGreatbow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oaken Great-bow");
            Tooltip.SetDefault("it's like the Longbow but better");
        }

        public override void SetDefaults()
        {
            item.ranged = true;
            item.damage = 24;
            item.useStyle = 5;
            item.useTime = 20;
            item.useAnimation = 10;
            item.height = 40;
            item.width = 40;
            item.shoot = AmmoID.Arrow;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 10;
            item.autoReuse = true;
            item.crit = 5;
            item.knockBack = 3;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.DemoniteBar, 2);
            recipe.AddIngredient(ItemID.CopperOre, 25);
            recipe.AddIngredient(mod.ItemType("OakenLongBow"));
            recipe.AddTile(mod.TileType("ArcherTableTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
