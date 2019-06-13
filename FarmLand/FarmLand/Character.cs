using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmLand
{
    class Character
    {
        private Texture2D WalkRight;
        private Texture2D WalkLeft;
        private Texture2D WalkUp;
        private Texture2D WalkDown;
        public Rectangle hitbox;
        private bool someKeyPressed;
        private int Speed;

        Animation animation;


        public Character()
        {
            hitbox = new Rectangle(0, 0, 24, 50);
            Speed = 3;
            someKeyPressed = false;
        }

        public void LoadContent(ContentManager Content)
        {


            WalkRight = Content.Load<Texture2D>("WalkRight");
            WalkLeft = Content.Load<Texture2D>("WalkLeft");
            WalkUp = Content.Load<Texture2D>("WalkUp");
            WalkDown = Content.Load<Texture2D>("WalkDown");



            animation = new Animation(WalkRight, 4, 1, hitbox);



        }
         public void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.W))
            {
                for (int i = 0; i < Speed; i++)
                {
                    animation.Update(gameTime, hitbox);
                    animation.SetTexture(WalkUp, 0);
                    animation.movetexture();
                    hitbox.Y--;
                }
                someKeyPressed = true;
            }
            if (ks.IsKeyDown(Keys.S))
            {
                for (int i = 0; i < Speed; i++)
                {
                    animation.Update(gameTime, hitbox);
                    animation.SetTexture(WalkDown, 0);
                    animation.movetexture();
                    hitbox.Y++;
                }
                someKeyPressed = true;
            }
            if (ks.IsKeyDown(Keys.A))
            {
                for (int i = 0; i < Speed; i++)
                {
                    animation.Update(gameTime, hitbox);
                    animation.SetTexture(WalkLeft, 0);
                    animation.movetexture();
                    hitbox.X--;
                }
                someKeyPressed = true;
            }
            if (ks.IsKeyDown(Keys.D))
            {
                for (int i = 0; i < Speed; i++)
                {
                    animation.Update(gameTime, hitbox);
                    animation.SetTexture(WalkRight, 0);
                    animation.movetexture();
                    hitbox.X++;
                }
                someKeyPressed = true;
            }
            if (someKeyPressed == false)
            {
                animation.ResetFrames(WalkRight);
            }
            animation.Update(gameTime, hitbox);
        }

        public void Draw(SpriteBatch spritebatch)
        {
            animation.Draw(spritebatch);
        }

    }
}
