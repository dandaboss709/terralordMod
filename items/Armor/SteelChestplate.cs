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
    // Added instread of AutoLoad
    [AutoloadEquip(EquipType.Body)]
    public class SteelChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Chestplate"); // Set the name
            Tooltip.SetDefault("Very heavy"); // Set the tooltop
        }

        public override void SetDefaults()
        {
            /* Removed in 0.10
            item.name = "Tutorial Breastplate";
            item.toolTip = "This is the Tutorial Breastplate";
            */
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 2;
            item.defense = 10; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("SteelHelmet") && legs.type == mod.ItemType("SteelBoots");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Endurance, 300);
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.statLifeMax2 += 60;
            player.moveSpeed /= 1.25f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SteelBar"), 25);
            recipe.AddIngredient(mod.ItemType("NightmareOre"), 10);
            recipe.AddTile(mod.TileType("SteelAnvil")); // Anvils = Iron, Lead, Mythril, etc
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
