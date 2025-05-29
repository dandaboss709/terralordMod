using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria.ModLoader;
using System.Threading.Tasks;
using Terraria.ID;


namespace terralord.items.Bars
{
    public class Cursedsteelbar:ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed Steel Bar");
            Tooltip.SetDefault("Frozen");
        }        
        public override void SetDefaults()
        {
            item.maxStack = 99;
            item.material = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.DemoniteBar, 2);
            recipe.AddIngredient(ItemID.CopperOre, 5);
            recipe.AddIngredient(mod.ItemType("SteelBar"), 2);
            recipe.AddTile(mod.TileType("SteelAnvil"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
