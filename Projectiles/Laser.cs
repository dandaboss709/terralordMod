using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;

namespace terralord.Projectiles
{
    public class Laser : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Laser");
        }
        public override void SetDefaults()
        {
            projectile.width = 4;
            projectile.height = 4;
            projectile.hostile = true;
            projectile.damage = 20;
            projectile.aiStyle = 0;
            projectile.tileCollide = false;
        }
        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + 1.57f;
            projectile.velocity *= 1.00001f;
        }
    }
}