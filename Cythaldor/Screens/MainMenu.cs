using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Cythaldor.Manager;
using Cythaldor.Guis;

namespace Cythaldor.Screens
{
    public class MainMenu : Screen
    {
        private Game game;

        public MainMenu(Game game)
        {
            this.game = game;
        }

        public void Init()
        {
            GameMain.SetGuiManager(new GuiManager(new MainMenuGui(game)));    
        }

        public void LoadContent(ContentManager content)
        {
            
        }

        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}
