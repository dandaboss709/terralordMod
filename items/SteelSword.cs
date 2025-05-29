using On.Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace terralord.items
{
    public class SteelSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel sword");
            Tooltip.SetDefault("a sword made from the finest steel");
        }
        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.width = 40;
            item.height = 40;
            item.shoot = mod.ProjectileType("SteelShard");
            item.shootSpeed = 5;
            item.damage = 16;
            item.autoReuse = true;
            item.crit = 6;
            item.knockBack = 1;
            item.melee = true;
            item.material = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SteelBar"), 5);
            recipe.AddIngredient(mod.ItemType("StoneSword"));
            recipe.AddTile(mod.TileType("SteelAnvil"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
