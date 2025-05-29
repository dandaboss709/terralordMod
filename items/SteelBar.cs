using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
namespace terralord.items
{
    public class SteelBar : ModItem
    {
        public override void SetStaticDefaults()
        { 
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.consumable = true;
            item.createTile = mod.TileType("BarPile");
            item.autoReuse = true;
            item.useStyle = 1;
            item.useAnimation = 10;
            item.useTime = 10;
            item.maxStack = 99;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddIngredient(mod.ItemType("Coal"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
