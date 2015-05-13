using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Cythaldor.Manager;
using Cythaldor.Screens;
using Cythaldor.Content;
using System;

namespace Cythaldor
{
    public class GameMain : Game
    {
        
        SpriteBatch spriteBatch;
        private static ScreenManager screenManager;

        private static GraphicsDeviceManager graphics;
        private static GuiManager guiManager;
        private static ResourcesManager resManager;

        private SpriteFont font;
        private bool DEBUG = false;


        public GameMain()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = true;
            IsMouseVisible = true;
            graphics.PreferredBackBufferHeight = 1080;
            graphics.PreferredBackBufferWidth = 1920;
            resManager = new ResourcesManager(Content);
            screenManager = new ScreenManager(new MainMenu(this));
        }

        protected override void Initialize()
        {
            screenManager.Init();
            guiManager.Init();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            screenManager.LoadContent(Content);
            font = Content.Load<SpriteFont>("font_base");
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            screenManager.Update(gameTime);
            guiManager.Update(gameTime);
            base.Update(gameTime);
        }

        float frameRate;

        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            screenManager.Draw(spriteBatch);
            guiManager.Draw(spriteBatch);
            if (DEBUG)
            {
                frameRate = 1 / (float)gameTime.ElapsedGameTime.TotalSeconds;
                spriteBatch.DrawString(font, frameRate.ToString(), new Vector2(0, 0), Color.White);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public static GuiManager GetGuiManager()
        {
            return guiManager;
        }
        public static GraphicsDeviceManager GetGraphics()
        {
            return graphics;
        }

        public static void SetGuiManager(GuiManager guiM)
        {
            guiManager = guiM;
        }

        public static ResourcesManager GetResManager()
        {
            return resManager;
        }

        public static ScreenManager GetScreenManager()
        {
            return screenManager;
        }
    }
}
