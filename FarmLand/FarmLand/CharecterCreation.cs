using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace FarmLand
{
    class CharecterCreation
    {
        
        public Texture2D SlctPantsTexRt;
        public Texture2D SlctPantsTexLft;
        public Rectangle SlctPantsHitRt;
        public Rectangle SlctPantsHitLft;
        Rectangle rectangle;
        Vector2 Position;
        public Vector2 size;

        PantsColor CurrentPants = PantsColor.Brown;
        ShirtColor CurrentShirt = ShirtColor.Blue;
        HairStyle CurrentHair = HairStyle.Hair1;



        enum PantsColor
        {
            Red,
            Blue,
            Brown,
        }

        enum HairStyle
        {
            Hair1, 
            Hair2,
            Hair3,
        }

        enum ShirtColor
        {
            Red,
            Blue, 
            Brown,
        }


        public CharecterCreation()
        {
            SlctPantsHitLft = new Rectangle(195, 154, 15, 15);
            SlctPantsHitRt = new Rectangle(293, 154, 15, 15);
        }

        public void LoadContent(ContentManager Content)
        {


            SlctPantsTexRt = Content.Load<Texture2D>("RightArrow");
            SlctPantsTexLft = Content.Load<Texture2D>("LeftArrow");
            

        }


        public void StreamWriter()
        {
            Int64 x;

            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter("C:\\Users\\mattr\\OneDrive\\Documents\\GitHub\\FarmLand\\Test1.txt", true, Encoding.ASCII);

                //Writeout the numbers 1 to 10 on the same line.
                for (x = 0; x < 10; x++)
                {
                    sw.Write(x);
                }

                //close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }


        public bool isClicked;
        public int Btn = 0;


        public void Update (MouseState mouse)
        {
            
            Rectangle mouseRectangle = new Rectangle(mouse.X, mouse.Y, 1, 1);
            rectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)size.X, (int)size.Y);

            
            //Pants buttons
            if (mouseRectangle.Intersects(SlctPantsHitRt))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    isClicked = true;

                    Btn = Btn + 1;
                    if (Btn == 6)
                    {
                        Btn = 0;
                    }
                    Debug.WriteLine(Btn);
                }
                
            }


            if (mouseRectangle.Intersects(SlctPantsHitLft))
            {
                if (mouse.LeftButton == ButtonState.Released)
                {
                    isClicked = true;

                    Btn = Btn - 1;
                    if (Btn == -1)
                    {
                        Btn = 5;
                    }
                }

            }

        }

        public void Draw (SpriteBatch spriteBatch)
        {


            switch(CurrentPants)
            {
                case PantsColor.Red:

                    break;
                case PantsColor.Blue:

                    break;
                case PantsColor.Brown:

                    break;
            }


            switch (CurrentShirt)
            {
                case ShirtColor.Red:

                    break;
                case ShirtColor.Blue:

                    break;
                case ShirtColor.Brown:

                    break;
            }

            switch (CurrentHair)
            {
                case HairStyle.Hair1:

                    break;
                case HairStyle.Hair2:

                    break;
                case HairStyle.Hair3:

                    break;
            }


            spriteBatch.Draw(SlctPantsTexLft, SlctPantsHitLft, Color.White);
            spriteBatch.Draw(SlctPantsTexRt, SlctPantsHitRt, Color.White);
        }
    }
}
