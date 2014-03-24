using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GPC_shmup
{
    public class Paint : Entity
    {
        public Paint(Vector2 position, Texture2D image, int scrollSpeed)
            : base(position, image)
        {
            this.speed = scrollSpeed;
        }

        public override void Update(GameTime gameTime)
        {
            if (normalizedVelocity == Vector2.Zero)
            {
                normalizedVelocity = new Vector2(-1, 0);
            }

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
