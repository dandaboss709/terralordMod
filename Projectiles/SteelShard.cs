using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
namespace terralord.Projectiles
{
    public class SteelShard : ModProjectile
    {
        public override void SetDefaults()
        {

            projectile.width = 10;
            projectile.height = 14;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.damage = 8;

        }
    }
}
