using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmLand
{
    class Inventory
    {

        public bool isActive;
        public List<Rectangle> mainSlots = new List<Rectangle>(24);
        public List<InventorySlot> mainSlotscheck = new List<InventorySlot>(24);
        public static Rectangle inv = new Rectangle(841, 469, 156, 231);
        public Rectangle invfull = new Rectangle(inv.X, inv.Y, inv.Width, inv.Height);
        public Rectangle inv1 = new Rectangle(inv.X + 4, inv.Y + 3, 32, 32);
        public Rectangle inv2 = new Rectangle(inv.X + 4, inv.Y + 3, 32, 32);
        public Rectangle inv3 = new Rectangle(inv.X + 4, inv.Y + 3, 32, 32);
        public Rectangle inv4 = new Rectangle(inv.X + 4, inv.Y + 3, 32, 32);
        //goes up to inv24 resulting in a 6x4 grid of Rectangles
        public Inventory()
        {
            mainSlots.Add(inv1); mainSlots.Add(inv2); mainSlots.Add(inv3); mainSlots.Add(inv4);
            //goes up to 24
            foreach (Rectangle slot in mainSlots)
                mainSlotscheck.Add(new InventorySlot(slot));
        }
        //update and draw methods are empty because im not too sure what to put there
        public int LookforfreeSlot()
        {
            int slotnumber = 999;
            for (int x = 0; x < mainSlots.Count; x++)
            {
                if (mainSlotscheck[x].isFree)
                {
                    slotnumber = x;
                    break;
                }
            }
            return slotnumber;
        }



    }
}
