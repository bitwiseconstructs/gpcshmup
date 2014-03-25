using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GPC_shmup
{
    public class Player : ShootableObject
    {
        //private static PowerUp defaultPowerUp;

        //private PowerUp primaryPowerUp;
        //private PowerUp secondaryPowerUp;

        private bool isXKeyDown = false;

        private BulletManager _bulletManager;

        public Player(Vector2 position, BulletManager bulletManager)
            : base(position)
        {
            speed = 300;
            _bulletManager = bulletManager;
        }

        //TODO: make this work. Currently is just pseudo code
        //public void SetPowerUp(PowerUp powerUp, bool isPrimary = true)
        //{
        //    if (isPrimary)
        //    {
        //        primaryPowerUp = powerUp;
        //    }
        //    else
        //    {
        //        secondaryPowerUp = powerUp;
        //    }
        //}

        //public void ClearPowerUps()
        //{
        //    primaryPowerUp = defaultPowerUp;
        //    secondaryPowerUp = null;
        //}

        public override void Update(GameTime gameTime)
        {
            Vector2 keyMovement = new Vector2();

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                keyMovement.Y--;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                keyMovement.Y++;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                keyMovement.X--;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                keyMovement.X++;
            }

            if (keyMovement != Vector2.Zero)
            {
                keyMovement.Normalize();
            }

            normalizedVelocity = keyMovement;

            if (Keyboard.GetState().IsKeyDown(Keys.X))
            {
                if (!isXKeyDown)
                {
                    _bulletManager.SpawnBullet(Position, new Vector2(1, 0), false);

                    isXKeyDown = true;
                }
            }
            else
            {
                isXKeyDown = false;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                _bulletManager.SpawnPaint(Position);
            }

            base.Update(gameTime);

            if (Position.Y < 40)
            {
                Position = new Vector2(Position.X, 40);
            }
            if (Position.Y > 760)
            {
                Position = new Vector2(Position.X, 760);
            }

            if (Position.X < 40)
            {
                Position = new Vector2(40, Position.Y);
            }

            if (Position.X > 1240)
            {
                Position = new Vector2(1240, Position.Y);
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
