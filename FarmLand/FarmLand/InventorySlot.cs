using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmLand
{
    class InventorySlot
    {
        public int X, Y;
        public int Width = 32, Height = 32;
        public Vector2 Position;
        public int slotnumber;
        public bool free = true;
        public int? content = null;

        public bool isFree
        {
            get { return free; }
            set { free = value; }
        }

        public InventorySlot(Rectangle slot)
        {
            slot = new Rectangle(X, Y, Width, Height);
        }
    }
}
}
