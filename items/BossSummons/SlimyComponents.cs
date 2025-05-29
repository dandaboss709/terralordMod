using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace terralord.items.BossSummons
{
    public class SlimyComponents : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Slimy components");
            Tooltip.SetDefault("Warning don't touch");
        }
        public override void SetDefaults()
        {
            item.useAnimation = 10;
            item.useStyle = 1;
            item.useTime = 10;
            item.width = 20;
            item.height = 26;
            item.consumable = true;
            item.maxStack = 99;
            
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SteelBar"), 5);
            recipe.AddIngredient(ItemID.Gel, 50);
            recipe.AddTile(mod.TileType("SteelAnvil"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Player player)
        {


            bool alreadySpawned = NPC.AnyNPCs(mod.NPCType("SlimeFactory"));
            return (!alreadySpawned);
        }
        public override bool UseItem(Player player)

        {
            if (Main.netMode != 1)
            {
                NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("SlimeFactory")); // Spawn the boss within a range of the player. 
            }
            else { NetMessage.SendData(MessageID.SpawnBoss, -1, -1, null, player.whoAmI, 1); }
            Main.PlaySound(SoundID.Roar, player.Right, 0);
            return true;


        }
    }
}
