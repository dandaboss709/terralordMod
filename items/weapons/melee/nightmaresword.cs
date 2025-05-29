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
    public class nightmaresword : ModItem
    { 
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nightmare sword");
            Tooltip.SetDefault("A sword made from the scariest of children's dreams");
        } 
        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTime = 20;
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
            recipe.AddIngredient(mod.ItemType("SteelBar"), 5);
            recipe.AddIngredient(mod.ItemType("NightmareOre"), 24);
            recipe.AddTile(mod.TileType("SteelAnvil"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
