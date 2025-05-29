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
    public class OakenLongBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oaken Longbow");
            Tooltip.SetDefault("it's a bow but longer");
        }

        public override void SetDefaults()
        {
            item.ranged = true;
            item.damage = 13;
            item.useStyle = 5;
            item.useTime = 20;
            item.useAnimation = 10;
            item.height = 40;
            item.width = 40;
            item.shoot = AmmoID.Arrow;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 10;
            item.crit = 3;
            item.knockBack = 3;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.IronBar, 2);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddTile(mod.TileType("ArcherTable"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
