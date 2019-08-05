using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmLand
{
    public class Item
    {
        public string name;
        public int itemID;
        public bool consumable;
        public bool stackable;
        public bool dragging;
        public bool IsActive;
        public int maxStack;
        public Rectangle DestinationRect;

    public Item(Rectangle rec, Texture2D tex, SpriteFont font)
        {

        }
    }
}