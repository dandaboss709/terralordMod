using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace terralord.items.weapons.melee
{
    public class StoneGreatsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Greatsword");
            Tooltip.SetDefault("might be useful");
        }
        public override void SetDefaults()
        {
            item.autoReuse = true;
            item.damage = 14;
            item.material = true;
            item.melee = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useStyle = 1;
            item.value = 50000;
            item.rare = 2;
            item.crit = 5;
            item.knockBack = 5;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("StoneSword"));
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
