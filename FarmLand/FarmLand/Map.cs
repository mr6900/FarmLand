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

        private Camera2D camera;

        public Camera2D Camera
        {
            get
            {
                return camera;
            }
        }

        private GraphicsDevice device;

        public Map(GraphicsDevice pDevice, int pTileWidth, int pTileHeight, int pWidth, int pHeight)
        {
            tileWidth = pTileWidth;
            tileHeight = pTileHeight;
            height = pHeight;
            width = pWidth;

            camera = new Camera2D(pDevice);
        }

        public void Update(GameTime gameTime)
        {
           
        }



        public void Draw (SpriteBatch spriteBatch)
        {
            
            Vector2 tilePosition = Vector2.Zero;

            


            //Drawing in tiles along x and y axis
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    spriteBatch.FillRectangle(tilePosition, new Size2(tileWidth, tileHeight), Color.White);
                    spriteBatch.FillRectangle(tilePosition + new Vector2(1, 1) , new Size2(tileWidth - 2, tileHeight - 2), Color.Black);
                    tilePosition.Y += tileHeight;
                }

                tilePosition.Y = 0;
                tilePosition.X += tileWidth;

            }
            

        }
    }
}
