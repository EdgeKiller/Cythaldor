using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor
{
    public class ScreenManager
    {
        Screen actualScreen;

        public ScreenManager(Screen screen)
        {
            actualScreen = screen;
            actualScreen.Initialize();
        }

        public void SetScreen(Screen screen)
        {
            actualScreen = screen;
            actualScreen.Initialize();
        }

        public void LoadContent(ContentManager content)
        {
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

    }
}
