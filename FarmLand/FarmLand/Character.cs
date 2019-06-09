using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
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
        private Texture2D facingRight;

        public Character()
        {
            
        }

        public void LoadContent(ContentManager Content)
        {
            WalkRight = Content.Load<Texture2D>("WalkRight");
            WalkLeft = Content.Load<Texture2D>("WalkLeft");
            WalkUp = Content.Load<Texture2D>("WalkUp");
            WalkDown = Content.Load<Texture2D>("WalkDown");
            //base.LoadContent(Content, "base_walk_edt_mid", "base_walk_edt_mid (2)", "jumpingedt", "jumpingedt (2)", "base_walk_edt_mid (2)", "base_walk_edt_mid");
        }

    }
}
