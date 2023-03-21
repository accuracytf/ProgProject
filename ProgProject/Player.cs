using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgProject
{
    internal class Player
    {

        public Texture2D playerTexture_Left, playerTexture_Right;
        public Vector2 playerPos;
        public Vector2 velocity;
        bool isGrounded;
        bool movingLeft;

        public Player(Texture2D pTexture_Left, Texture2D pTexture_Right, Vector2 position)
        {
            this.playerTexture_Left = pTexture_Left;
            this.playerTexture_Right = pTexture_Right;
            this.playerPos = position;
            isGrounded = false;

        }
        public void Update()
        {
            KeyboardState ks = Keyboard.GetState();

            playerPos += velocity;
            velocity.X = 0;
            if (ks.IsKeyDown(Keys.A))
            {
                velocity.X = -3f;
                movingLeft = true;            
            }
            if (ks.IsKeyDown(Keys.D))
            {
                velocity.X = 3f;
                movingLeft = false;
            }
            if (ks.IsKeyDown(Keys.Space) && isGrounded)
            {
                playerPos.Y -= 20f;
                velocity.Y = -10f;
                isGrounded = false;
            }
            if (!isGrounded)
            {
                float i = 1;
                velocity.Y += 0.15f * i;
            }
            
            if (playerPos.Y + playerTexture_Right.Height >= 720)
            {
                isGrounded = true;
            }
            if (isGrounded)
            {
                velocity.Y = 0f;
            }

            if (playerPos.X + playerTexture_Right.Width > 1280)
            {
                playerPos.X = 1280 - playerTexture_Right.Width;
            }
            if (playerPos.X < 0)
            {
                playerPos.X = 0;
            }
        



        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if(movingLeft)
                spriteBatch.Draw(playerTexture_Left, playerPos, Color.White);
            if(!movingLeft)
                spriteBatch.Draw(playerTexture_Right, playerPos, Color.White);


            // TODO: Add your drawing code here

        }


    }
}
