using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FarmLand
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        CharecterCreation CharecterCreation;

        enum GameState
        {
            MainMenu,
            CharecterCreation,
            Options,
            Playing,
        }
        GameState CurrentState = GameState.MainMenu;

        int screenWidth = 800, screenHeight = 600;


        cButton plyBtn;
        cButton BckBtn;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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

            plyBtn = new cButton(Content.Load<Texture2D>("StartButton"), graphics.GraphicsDevice);
            plyBtn.setPosition(new Vector2(350, 300));
            BckBtn = new cButton(Content.Load<Texture2D>("BackButton"), graphics.GraphicsDevice);
            BckBtn.setPosition(new Vector2(0, 0));
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
                    if (plyBtn.isClicked == true) CurrentState = GameState.CharecterCreation;
                    plyBtn.Update(mouse);
                    break;
                case GameState.Options:

                    break;
                case GameState.Playing:

                    break;
                case GameState.CharecterCreation:
                    if (BckBtn.isClicked == true) CurrentState = GameState.MainMenu;
                    BckBtn.Update(mouse);
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
                    break;
                case GameState.Options:

                    break;
                case GameState.Playing:

                    break;
                case GameState.CharecterCreation:
                    spriteBatch.Draw(Content.Load<Texture2D>("CreationScreen"), new Rectangle(0, 0, screenWidth, screenHeight), Color.White);
                    BckBtn.Draw(spriteBatch);
                    break;
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
