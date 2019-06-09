using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Design;
using System.Collections.Generic;

namespace FarmLand
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        enum GameState
        {
            MainMenu,
            CharecterCreation,
            Options,
            Playing,
            Load,
        }
        GameState CurrentState = GameState.MainMenu;

        int screenWidth = 800, screenHeight = 600;


        cButton plyBtn;
        cButton BckBtn;
        cButton OptBtn;
        cButton RandBtn;
        cButton LdBtn;
        Song song;
        public Texture2D SlctTexRt;
        public Texture2D SlctTexLft;
        public List<Rectangle> SlctHitLft;
        public List<Rectangle> SlctHitRt;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            SlctHitLft = new List<Rectangle>();
            SlctHitRt = new List<Rectangle>();
            SlctHitLft.Add(new Rectangle(195, 154, 15, 15));
            SlctHitRt.Add(new Rectangle(293, 154, 15, 15));
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            //graphics.IsFullScreen = true;
            IsMouseVisible = true;

            RandBtn = new cButton(Content.Load<Texture2D>("RandomButton"), graphics.GraphicsDevice);
            RandBtn.setPosition(new Vector2(100, 10));
            OptBtn = new cButton(Content.Load<Texture2D>("Options"), graphics.GraphicsDevice);
            OptBtn.setPosition(new Vector2(350, 350));
            plyBtn = new cButton(Content.Load<Texture2D>("Start"), graphics.GraphicsDevice);
            plyBtn.setPosition(new Vector2(350, 250));
            BckBtn = new cButton(Content.Load<Texture2D>("Back"), graphics.GraphicsDevice);
            BckBtn.setPosition(new Vector2(0, 0));
            LdBtn = new cButton(Content.Load<Texture2D>("Load"), graphics.GraphicsDevice);
            LdBtn.setPosition(new Vector2(350, 300));
            SlctTexRt = Content.Load<Texture2D>("RightArrow");
            SlctTexLft = Content.Load <Texture2D>("LeftArrow");



        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            MouseState mouse = Mouse.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            switch (CurrentState)
            {
                case GameState.MainMenu:
                    //Play Button
                    if (plyBtn.isClicked == true)
                    {
                        CurrentState = GameState.CharecterCreation;
                        BckBtn.isClicked = false;
                    }
                    //Option Button
                    if (OptBtn.isClicked == true)
                    {
                        CurrentState = GameState.Options;
                        BckBtn.isClicked = false;
                    }
                    //Load Button
                    if (LdBtn.isClicked == true)
                    {
                        CurrentState = GameState.Load;
                        BckBtn.isClicked = false;
                    }
                    //Updates
                    OptBtn.Update(mouse);
                    plyBtn.Update(mouse);
                    BckBtn.Update(mouse);
                    LdBtn.Update(mouse);
                    break;
                case GameState.CharecterCreation:
                    //Back Buuton
                    if (BckBtn.isClicked == true)
                    {
                        CurrentState = GameState.MainMenu;
                        plyBtn.isClicked = false;
                        LdBtn.isClicked = false;
                    }
                    //Updates
                    RandBtn.Update(mouse);
                    BckBtn.Update(mouse);
                    break;
                case GameState.Options:
                    //Back Button
                    if (BckBtn.isClicked == true)
                    {
                        CurrentState = GameState.MainMenu;
                        plyBtn.isClicked = false;
                        OptBtn.isClicked = false;
                        LdBtn.isClicked = false;
                    }
                    //Updates
                    OptBtn.Update(mouse);
                    plyBtn.Update(mouse);
                    BckBtn.Update(mouse);
                    break;
                case GameState.Playing:
                    //Updates
                    break;
                case GameState.Load:
                    if (BckBtn.isClicked == true)
                    {
                        CurrentState = GameState.MainMenu;
                        plyBtn.isClicked = false;
                        LdBtn.isClicked = false;
                    }
                    BckBtn.Update(mouse);
                    //Updates
                    break;

            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            switch (CurrentState)
            {
                case GameState.MainMenu:
                    spriteBatch.Draw(Content.Load<Texture2D>("MainMenu"), new Rectangle(0, 0, screenWidth, screenHeight), Color.White);
                    plyBtn.Draw(spriteBatch);
                    OptBtn.Draw(spriteBatch);
                    LdBtn.Draw(spriteBatch);
                    break;
                case GameState.CharecterCreation:
                    spriteBatch.Draw(Content.Load<Texture2D>("CreationScreen"), new Rectangle(0, 0, screenWidth, screenHeight), Color.White);
                    for (int i = 0; i < SlctHitLft.Count; i++)
                    {
                        spriteBatch.Draw(SlctTexLft, SlctHitLft[i], Color.White);
                    }
                    for (int i = 0; i < SlctHitRt.Count; i++)
                    {
                        spriteBatch.Draw(SlctTexRt, SlctHitRt[i], Color.White);
                    }
                    RandBtn.Draw(spriteBatch);
                    BckBtn.Draw(spriteBatch);
                    break;
                case GameState.Options:
                    BckBtn.Draw(spriteBatch);
                    break;
                case GameState.Playing:

                    break;
                case GameState.Load:
                    BckBtn.Draw(spriteBatch);
                    break;

            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
