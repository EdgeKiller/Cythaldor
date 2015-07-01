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
using Cythaldor.GameClasses.Utils;

namespace Cythaldor.Screens
{
    class InGame : IScreen
    {
        private Game game;
        private Camera camera;
        
        public InGame(Game game)
        {
            this.game = game;
        }

        public void Init()
        {
            camera = new Camera();
            GameMain.GetGuiManager().SetGui(new InGameGui(game));
        }

        public void LoadContent(ContentManager content)
        {
            
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState kbState = Keyboard.GetState();
            if (kbState.IsKeyDown(Keys.Up))
                camera.AddPosition(0, -1);
            if (kbState.IsKeyDown(Keys.Down))
                camera.AddPosition(0, 1);
            if (kbState.IsKeyDown(Keys.Left))
                camera.AddPosition(-1, 0);
            if (kbState.IsKeyDown(Keys.Right))
                camera.AddPosition(1, 0);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}
