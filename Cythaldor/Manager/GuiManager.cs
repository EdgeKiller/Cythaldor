using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Cythaldor.GuiElements;

namespace Cythaldor.Manager
{
    public class GuiManager
    {
        private Gui actualGui;

        public GuiManager(Gui gui)
        {
            actualGui = gui;
        }

        public void Init()
        {
            actualGui.Init();
        }
        
        public void Update(GameTime gameTime)
        {
            actualGui.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            actualGui.Draw(spriteBatch);
        }

        public void SetGui(Gui gui)
        {
            actualGui = gui;
            Init();
            foreach(GuiElement guiElem in gui.guiList)
            {
                if(guiElem is Button)
                {
                    Button guiButton = (Button)guiElem;
                    guiButton.SetClicked();
                }
            }
        }
        public Gui GetGui()
        {
            return actualGui;
        }

    }
}
