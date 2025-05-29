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
    public class SteelPick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel pickaxe");
            Tooltip.SetDefault("Great quality Sheffield Steel");
        }
        public override void SetDefaults()
        {
            item.pick = 70;
            item.useAnimation = 5;
            item.useStyle = 1;
            item.width = 36;
            item.height = 36;
            item.useTime = 5;
            item.knockBack = 3;
            item.damage = 8;
            item.autoReuse = true;
            item.crit = 3;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SteelBar"), 12);
            recipe.AddIngredient(ItemID.IronPickaxe);
            recipe.AddIngredient(ItemID.IceBlock);
            recipe.AddTile(mod.TileType("SteelAnvil"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("SteelBar"), 12);
            r.AddIngredient(ItemID.LeadPickaxe);
            r.AddTile(mod.TileType("SteelAnvil"));
            r.SetResult(this);
            r.AddRecipe();
        }
    } 
}
