using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor.Manager
{
    public class ScreenManager
    {
        private IScreen actualScreen;

        private ContentManager content;

        public ScreenManager(IScreen screen)
        {
            actualScreen = screen;
        }

        public void Init()
        {
            actualScreen.Init();
        }

        public void LoadContent(ContentManager content)
        {
            this.content = content;
            actualScreen.LoadContent(content);
        }

        public void Update(GameTime gameTime)
        {
            actualScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            actualScreen.Draw(spriteBatch);
        }

        public void SetScreen(IScreen screen)
        {
            actualScreen = screen;
            actualScreen.Init();
            actualScreen.LoadContent(content);
        }
        public IScreen GetScreen()
        {
            return actualScreen;
        }

    }
}
