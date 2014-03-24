using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GPC_shmup
{
    public class BulletManager
    {
        private List<Bullet> bullets = new List<Bullet>();
        private List<Paint> paint = new List<Paint>();
        private Texture2D bulletImage;

        public void LoadContent(ContentManager content)
        {
            bulletImage = content.Load<Texture2D>("bullet");
        }

        public void Update(GameTime gameTime)
        {
            foreach (Bullet b in bullets)
            {
                b.Update(gameTime);
            }

            foreach (Paint p in paint)
            {
                p.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Bullet b in bullets)
            {
                b.Draw(spriteBatch);
            }
            foreach (Paint p in paint)
            {
                p.Draw(spriteBatch);
            }
        }

        public void SpawnBullet(Vector2 position, Vector2 facing, bool isEnemy = true)
        {
            bullets.Add(new Bullet(position, facing, bulletImage, isEnemy));
        }

        public void SpawnPaint(Vector2 position)
        {
            paint.Add(new Paint(position, bulletImage, 50));
        }
    }
}
