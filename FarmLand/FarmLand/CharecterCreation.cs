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
    class CharecterCreation
    {


        public Texture2D SlctTexRt;
        public Texture2D SlctTexLft;
        public List<Rectangle> SlctHitLft;
        public List<Rectangle> SlctHitRt;


        public CharecterCreation()
        {
            
            SlctHitLft = new List<Rectangle>();
            SlctHitRt = new List<Rectangle>();
            SlctHitLft.Add(new Rectangle(195, 154, 15, 15));
            SlctHitRt.Add(new Rectangle(293, 154, 15, 15));
            
        }

        public void LoadContent(ContentManager Content)
        {
            
            SlctTexRt = Content.Load<Texture2D>("RightArrow");
            SlctTexLft = Content.Load<Texture2D>("LeftArrow");

        }

        public void Update (GameTime gameTime)
        {



        }

        public void Draw (SpriteBatch spriteBatch)
        {
            for (int i = 0; i < SlctHitLft.Count; i++)
            {
                spriteBatch.Draw(SlctTexLft, SlctHitLft[i], Color.White);
            }
            for (int i = 0; i < SlctHitRt.Count; i++)
            {
                spriteBatch.Draw(SlctTexRt, SlctHitRt[i], Color.White);
            }
        }
    }
}
