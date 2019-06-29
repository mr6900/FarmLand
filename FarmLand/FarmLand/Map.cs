using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmLand
{
    class Map
    {

        private int tileWidth;
        private int tileHeight;
        private int width;
        private int height;

        public Map(int pTileWidth, int pTileHeight, int pWidth, int pHeight)
        {
            tileWidth = pTileWidth;
            tileHeight = pTileHeight;
            height = pHeight;
            width = pWidth;
        }

        public void Update(GameTime gameTime)
        {

        }



        public void Draw (SpriteBatch spriteBatch)
        {
            
            Vector2 tilePosition = Vector2.Zero;
            

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    spriteBatch.FillRectangle(tilePosition, new Size2(tileWidth, tileHeight), Color.Black);
                    tilePosition.Y += tileHeight;
                }

                tilePosition.Y = 0;
                tilePosition.X += tileWidth;

            }
            
        }
    }
}
