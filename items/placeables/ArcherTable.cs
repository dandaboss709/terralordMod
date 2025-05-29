using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace terralord.items.placeables
{
    public class ArcherTable : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Archer Table");
            Tooltip.SetDefault("Best place to make a bow");

        }
        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
            item.maxStack = 99;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.value = 10000;
            item.consumable = true;
            item.createTile = mod.TileType("ArcherTable");
            item.autoReuse = true;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddIngredient(mod.ItemType("SteelBar"), 2);
            recipe.AddIngredient(ItemID.StoneBlock, 3);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
