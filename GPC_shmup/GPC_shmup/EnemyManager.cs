using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GPC_shmup
{
    public class EnemyManager
    {
        private TimeSpan enemySpawnRate = new TimeSpan(0, 0, 2);
        private TimeSpan? lastTimeEnemySpawned = null;

        private List<Enemy> enemies = new List<Enemy>();
        private Texture2D enemyImage;

        public EnemyManager()
        {

        }

        public void LoadContent(ContentManager content)
        {
            enemyImage = content.Load<Texture2D>("enemy");
        }

        public void Update(GameTime gameTime, int currentScore)
        {
            if (lastTimeEnemySpawned == null)
            {
                lastTimeEnemySpawned = gameTime.TotalGameTime;
            }

            if (gameTime.TotalGameTime - lastTimeEnemySpawned > enemySpawnRate)
            {
                if (currentScore < 500)
                {
                    enemies.Add(new Enemy(new Vector2(1400, RandomHelper.Random.Next(30, 770)), enemyImage));
                }
                else
                {
                    enemySpawnRate = new TimeSpan(0, 0, 0, 1, 500);
                }

                lastTimeEnemySpawned = gameTime.TotalGameTime;
            }

            List<Enemy> enemiesToDestroy = null;

            foreach (Enemy e in enemies)
            {
                e.Update(gameTime);

                if (e.ShouldBeDisposed)
                {
                    if (enemiesToDestroy == null)
                    {
                        enemiesToDestroy = new List<Enemy>();
                    }

                    enemiesToDestroy.Add(e);
                }
            }

            if (enemiesToDestroy != null)
            {
                foreach (Enemy e in enemiesToDestroy)
                {
                    enemies.Remove(e);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Enemy e in enemies)
            {
                e.Draw(spriteBatch);
            }
        }
    }
}
