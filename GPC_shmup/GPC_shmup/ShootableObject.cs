using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GPC_shmup
{
    public class ShootableObject : Entity
    {
        public int Health { get; set; }
        public Rectangle HitBox { get; set; }

        public ShootableObject(Vector2 position, Texture2D image = null)
            : base(position, image)
        {
        }

        public void LoadContent(ContentManager content)
        {
            image = content.Load<Texture2D>("character");
        }
    }
}
