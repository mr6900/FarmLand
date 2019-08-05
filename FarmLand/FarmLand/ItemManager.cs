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
    class ItemManager
    {
        public List<Item> items = new List<Item>(20);
        public List<Item> inventory1 = new List<Item>(24);
        public List<Item> inventory2 = new List<Item>(24);
        public List<Item> inventory3 = new List<Item>(24);
        public List<Item> inventory4 = new List<Item>(24);
        public Texture2D icon, filta;
        private Rectangle msRect;
        MouseState mouseState;
        public int ISelectedIndex;
        Inventory inventory;
        SpriteFont font;

        public void GenerateItems()
        {
            items.Add(new Item(new Rectangle(0, 0, 32, 32), icon, font));
            items[0].name = "Grass Chip";
            items[0].itemID = 0;
            items[0].consumable = true;
            items[0].stackable = true;
            items[0].maxStack = 99;
            items.Add(new Item(new Rectangle(32, 0, 32, 32), icon, font));
            //master list continues. it will generate all items in the game;

        }
        public ItemManager(Inventory inv, Texture2D itemsheet, Rectangle mouseRectt, MouseState ms, Texture2D fil,
                                    SpriteFont f)
        {
            icon = itemsheet;
            msRect = mouseRectt;
            filta = fil;
            mouseState = ms;
            inventory = inv;
            font = f;
        }
        //once again, no update or draw
        public void mousedrag()
        {

            items[0].DestinationRect = new Rectangle(msRect.X, msRect.Y, 32, 32);
            items[0].dragging = true;


        }

        public void AddtoInventory(Item item)
        {
            int index = inventory.LookforfreeSlot();
            if (index == 999)
                return;
            item.DestinationRect = inventory.mainSlots[index];
            inventory.mainSlotscheck[index].content = item.itemID;
            inventory.mainSlotscheck[index].isFree = false;
            item.IsActive = true;
        }

    }
}

