using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace terralord.items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SteelHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Helmet");
            Tooltip.SetDefault("very heavy");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 2;
            item.defense = 9; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("SteelChestplate") && legs.type == mod.ItemType("SteelBoots");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Endurance, 300);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SteelBar"), 20);
            recipe.AddIngredient(mod.ItemType("NightmareOre"), 10);
            recipe.AddTile(mod.TileType("SteelAnvil")); // Anvils = Iron, Lead, Mythril, etc
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
