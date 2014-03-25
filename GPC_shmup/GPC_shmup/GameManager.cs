using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GPC_shmup
{
    public class GameManager
    {
        private int distanceScrolled;

        private BulletManager _bulletManager;
        private EnemyManager _enemyManager;

        private List<Vector2> paintBlobStorage = new List<Vector2>();

        public GameManager()
        {
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        //TODO: call this method when paint blobs go off screen
        public void SavePaintBlob(Vector2 relativePosition)
        {
            paintBlobStorage.Add(relativePosition + new Vector2(distanceScrolled, 0));
        }
    }
}
