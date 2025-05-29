using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terralord.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace terralord.items.weapons.Ranged
{
    public class BoltGun : ModItem
    {

        public override void SetDefaults()
        {
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.useStyle = 5;
            item.useTime = 27;
            item.useAnimation = 30;
            item.autoReuse = true;
            item.damage = 19;
            item.knockBack = 4;
            item.shootSpeed = 20f;
            item.noMelee = true;
            item.crit = 15;
            item.value = 500;
            item.shoot = ModContent.ProjectileType<Bolt>();
            item.expert = true;

        }
    }

}
