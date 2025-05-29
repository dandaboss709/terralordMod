using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace terralord.items.Bossbags
{
    public class SlimeFactoryBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Factory Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.rare = 11;
            item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            //player.TryGettingDevArmor();

            int choice = Main.rand.Next(3); // use for unique items this means 0 to 4 if Main.rand.Next(5)

            if (choice == 0)
            {
                player.QuickSpawnItem(mod.ItemType("ColdSteelBar"));
            }
            else if (choice == 1)
            {
                player.QuickSpawnItem(mod.ItemType("OakenGreabow"));
            }
            else if (choice == 2)
            {
                player.QuickSpawnItem(mod.ItemType("BoltGun"));
            }



            player.QuickSpawnItem(mod.ItemType("SteelBar"), 25);
            player.QuickSpawnItem(ItemID.CopperOre, 30);
            player.QuickSpawnItem(ItemID.IronOre,25);
            player.QuickSpawnItem(mod.ItemType("NightmareOre"), Main.rand.Next(3, 22));
        }

        public override int BossBagNPC => mod.NPCType("SlimeFactory");
    }
}