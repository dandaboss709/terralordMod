using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace terralord.items.weapons.Ranged
{
    public class FrostBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost bow");
            Tooltip.SetDefault("cold to the touch");
        }
        public override void SetDefaults()
        {
            item.noMelee = true;
            item.ranged = true;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = ProjectileID.FrostArrow;
            item.shootSpeed = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.useTime = 10;
            item.damage = 34;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.anyIronBar = true;
            recipe.AddIngredient(mod.ItemType("NightmareOre"), 10);
            recipe.AddIngredient(ItemID.IceBlock, 50);
            recipe.AddIngredient(mod.ItemType("ColdSteelBar"));
            recipe.AddTile(mod.TileType("ArcherTableTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
