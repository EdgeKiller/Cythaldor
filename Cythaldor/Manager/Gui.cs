using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using Cythaldor.GuiElements;
using Microsoft.Xna.Framework.Input;

namespace Cythaldor.Manager
{
    public class Gui
    {
        public List<GuiElement> guiList = new List<GuiElement>();

        public virtual void Init()
        {
            
        }

        public void Update(GameTime gameTime)
        {
            foreach (GuiElement guiElem in guiList)
            {
                guiElem.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (GuiElement guiElem in guiList)
            {
                guiElem.Draw(spriteBatch);
            }
        }

    }
}
