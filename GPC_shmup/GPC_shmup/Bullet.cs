using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GPC_shmup
{
    public class Bullet : Entity
    {
        public int Damage { get; set; }

        private bool isEnemy;
        private Vector2 facing;

        public Bullet(Vector2 position, Vector2 facing, Texture2D image, bool isEnemy)
            : base(position, image)
        {
            this.facing = facing;
            this.isEnemy = isEnemy;
            this.speed = 800;
        }

        public override void Update(GameTime gameTime)
        {
            if (normalizedVelocity == Vector2.Zero)
            {
                normalizedVelocity = facing;
            }

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
