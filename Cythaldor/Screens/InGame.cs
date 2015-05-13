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
    class InGame : IScreen
    {

        private Game game;
        
        public InGame(Game game)
        {
            this.game = game;
        }

        public void Init()
        {
            GameMain.SetGuiManager(new GuiManager(null));    
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
