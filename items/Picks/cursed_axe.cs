using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace terralord.items.Picks
{
    public class cursed_axe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed Axe");
            Tooltip.SetDefault("don't touch");
        }
        public override void SetDefaults()
        {
            item.axe = 70;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.useTime = 25;
            item.knockBack = 9;
            item.damage = 21;
            item.autoReuse = true;
            item.crit = 5;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Cursedfragment"), 12);
            recipe.AddIngredient(ItemID.IronAxe);
            recipe.AddTile(mod.TileType("SteelAnvil"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("Cursedfragment"), 12);
            r.AddIngredient(ItemID.LeadAxe);
            r.AddTile(mod.TileType("SteelAnvil"));
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
