using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace terralord.items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class SteelBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel boots");
            Tooltip.SetDefault("Very heavy");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 12;
            item.value = 1000;
            item.rare = 2;
            item.defense = 7; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("SteelChestplate") && head.type == mod.ItemType("SteelHelmet");
        }


        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Endurance, 300);
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient (mod.ItemType("SteelBar"), 15);
            recipe.AddIngredient(mod.ItemType("NightmareOre"), 10);
            recipe.AddTile(mod.TileType("SteelAnvil")); // Anvils = Iron, Lead, Mythril, etc
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
