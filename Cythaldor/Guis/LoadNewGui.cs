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
    public class LoadNewGui : Gui
    {
        Button buttonNew, buttonReturn, buttonLoad;
        Cursor cursor;
        ImageRectangle bg, header;

        private Game game;

        public LoadNewGui(Game game)
        {
            this.game = game;
        }

        public override void Init()
        {

            bg = new ImageRectangle(new Color(107, 186, 112), new Rectangle(0, 0, GameMain.GetGraphics().PreferredBackBufferWidth, GameMain.GetGraphics().PreferredBackBufferHeight));

            header = new ImageRectangle("header", new Rectangle(0, 50, 400, 100));
            header.CenterX(GameMain.GetGraphics().PreferredBackBufferWidth, GameMain.GetGraphics().PreferredBackBufferHeight);

            buttonNew = new Button("button_blue", new Rectangle(0, 280, 190, 49), "New", "font_base", "font_base_small", Color.Orange, "button_blue_over");
            buttonNew.CenterX(GameMain.GetGraphics().PreferredBackBufferWidth, GameMain.GetGraphics().PreferredBackBufferHeight);
            buttonNew.onMouseClick += buttonNew_onMouseClick;

            buttonLoad = new Button("button_blue", new Rectangle(0, 340, 190, 49), "Load", "font_base", "font_base_small", Color.Orange, "button_blue_over");
            buttonLoad.CenterX(GameMain.GetGraphics().PreferredBackBufferWidth, GameMain.GetGraphics().PreferredBackBufferHeight);

            buttonReturn = new Button("button_blue", new Rectangle(0, 400, 190, 49), "Return", "font_base", "font_base_small", Color.Orange, "button_blue_over");
            buttonReturn.CenterX(GameMain.GetGraphics().PreferredBackBufferWidth, GameMain.GetGraphics().PreferredBackBufferHeight);
            buttonReturn.onMouseClick += buttonReturn_onMouseClick;

            cursor = new Cursor("cursor_menu", new Point(Mouse.GetState().X, Mouse.GetState().Y));

            guiList.Add(bg);
            guiList.Add(header);
            guiList.Add(buttonNew);
            guiList.Add(buttonLoad);
            guiList.Add(buttonReturn);
            guiList.Add(cursor);
        }

        void buttonNew_onMouseClick(object sender, EventArgs e)
        {
            GameMain.GetScreenManager().SetScreen(new InGame(game));
        }

        void buttonReturn_onMouseClick(object sender, EventArgs e)
        {
            GameMain.GetGuiManager().SetGui(new MainMenuGui(game));
        }

    }
}
