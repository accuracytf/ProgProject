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
        
        public Texture2D playerTexture;
        public Vector2 playerPos;
        public Vector2 velocity;
        bool isGrounded;


        public Player(Texture2D pTexture, Vector2 position)
        {
            this.playerTexture = pTexture;
            this.playerPos = position;
            isGrounded = false;

        }
        public void Update()
        {
            KeyboardState ks = Keyboard.GetState();

            playerPos += velocity;
            if (ks.IsKeyDown(Keys.A)){
                velocity.X = -3f;
            }
            if (ks.IsKeyDown(Keys.D))
            {
                velocity.X = 3f;
            }
            if (ks.IsKeyDown(Keys.Space) && isGrounded)
            {
                playerPos.Y -= 10f;
                velocity.Y = -5f;
                isGrounded = false;
            }
            if (!isGrounded)
            {
                float i = 1;
                velocity.Y += 0.15f * i;
            }
            
            if (playerPos.Y + playerTexture.Height >= 720)
            {
                isGrounded = true;
            }
            if (isGrounded)
            {
                velocity.Y = 0f;
            }

            



        }
        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(playerTexture, playerPos, Color.White);

            // TODO: Add your drawing code here

        }


    }
}
