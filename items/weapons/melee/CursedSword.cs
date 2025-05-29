using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Win32;

namespace terralord.items.weapons.melee
{
    public class CursedSword : ModItem
    { 
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed sword");
            Tooltip.SetDefault("Someone died in this sword");
        } 
        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTime = 40;
            item.useAnimation = 10;
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
            recipe.AddIngredient(mod.ItemType("CursedSteelBar"), 5);
            recipe.AddIngredient(mod.ItemType("CursedFragment"), 4);
            recipe.AddTile(mod.TileType("SteelAnvil"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
