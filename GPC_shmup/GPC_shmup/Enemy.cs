using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GPC_shmup
{
    public class Enemy : ShootableObject
    {
        public bool ShouldBeDisposed = false;

        public Enemy(Vector2 position, Texture2D image)
            : base(position, image)
        {
            this.normalizedVelocity = new Vector2(-1, 0);
            this.speed = 200;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (Position.X < -30)
            {
                ShouldBeDisposed = true;
            }
        }
    }
}
