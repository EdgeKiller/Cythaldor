using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cythaldor.Manager;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Cythaldor.GuiElements;
using Cythaldor.Screens;


namespace Cythaldor.Guis
{
    public class InGameGui : Gui
    {
        private Cursor cursor;

        private Game game;

        public InGameGui(Game game)
        {
            this.game = game;
        }

        public override void Init()
        {
            cursor = new Cursor("cursor_menu", new Point(Mouse.GetState().X, Mouse.GetState().Y));
            guiList.Add(cursor);
        }

        public void SetCursorTexture(string texture)
        {
            cursor.SetTexture(texture);
        }

    }
}
