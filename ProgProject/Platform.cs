using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgProject
{
    internal class Platform
    {
        public Texture2D platformTexture;
        public Rectangle platformRect;
        public Vector2 platformPos;
        public Platform(Texture2D platTexture, Vector2 position)
        {
            this.platformTexture = platTexture;
            this.platformPos = position;
        }

        public Rectangle GetRect() 
        {
            platformRect = new Rectangle((int)platformPos.X, (int)platformPos.Y, platformTexture.Width, platformTexture.Height);
            return platformRect;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(platformTexture, platformPos, Color.White);


            // TODO: Add your drawing code here

        }
    }
}
