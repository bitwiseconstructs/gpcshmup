using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GPC_shmup
{
    public class Entity
    {
        public Vector2 Position { get; set; }

        protected Texture2D image;
        protected Vector2 normalizedVelocity;
        protected float speed;

        public Entity(Vector2 position, Texture2D image)
        {
            Position = position;
            this.image = image;
        }

        public virtual void Update(GameTime gameTime)
        {
            if (normalizedVelocity != Vector2.Zero)
            {
                Position += normalizedVelocity * (float)(speed * gameTime.ElapsedGameTime.TotalMilliseconds / 1000);
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                image, 
                new Rectangle((int)Position.X, (int)Position.Y, image.Width, image.Height), 
                new Rectangle(0, 0, image.Width, image.Height),
                Color.White,
                0,
                new Vector2(image.Width / 2, image.Height / 2),
                SpriteEffects.None,
                0f);
        }
    }
}
