using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace terralord.Projectiles
{
    public class Bolt : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.damage = 15;
            projectile.aiStyle = 0;
            projectile.width = 8;
            projectile.height = 8;
            projectile.penetrate = 2;
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;



        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.Kill();
            return false;
        }
    }
}
