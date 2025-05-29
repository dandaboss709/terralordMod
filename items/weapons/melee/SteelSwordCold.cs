using On.Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace terralord.items.weapons.melee
{
    public class SteelSwordCold : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frozen Steel sword");
            Tooltip.SetDefault("cold to the touch");
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
            item.damage = 21;
            item.autoReuse = true;
            item.crit = 6;
            item.knockBack = 2;
            item.buffType = BuffID.Frostburn;
            item.buffTime = 2;
            item.melee = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SteelSword"));
            recipe.AddIngredient(mod.ItemType("ColdSteelBar"));
            recipe.AddTile(mod.TileType("SteelAnvil"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
