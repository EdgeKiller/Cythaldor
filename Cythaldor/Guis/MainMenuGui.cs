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

namespace Cythaldor.Guis
{
    public class MainMenuGui : Gui
    {
        Button buttonPlay, buttonExit;
        Cursor cursor;
        ImageRectangle bg, header;

        private Game game;

        public MainMenuGui(Game game)
        {
            this.game = game;
        }

        public override void Init()
        {

            bg = new ImageRectangle(new Color(107,186,112), new Rectangle(0, 0, GameMain.GetGraphics().PreferredBackBufferWidth, GameMain.GetGraphics().PreferredBackBufferHeight));

            header = new ImageRectangle("header", new Rectangle(0, 50, 400, 100));
            header.CenterX(GameMain.GetGraphics().PreferredBackBufferWidth, GameMain.GetGraphics().PreferredBackBufferHeight);

            buttonPlay = new Button("button_play", new Rectangle(0, 250, 190, 49), "button_play_over");
            buttonPlay.CenterX(GameMain.GetGraphics().PreferredBackBufferWidth, GameMain.GetGraphics().PreferredBackBufferHeight);
            buttonPlay.onMouseClick += buttonPlay_onMouseClick;

            buttonExit = new Button("button_exit", new Rectangle(0, 320, 190, 49), "button_exit_over");
            buttonExit.CenterX(GameMain.GetGraphics().PreferredBackBufferWidth, GameMain.GetGraphics().PreferredBackBufferHeight);
            buttonExit.onMouseClick += buttonExit_onMouseClick;

            cursor = new Cursor("cursor_menu", new Point(Mouse.GetState().X, Mouse.GetState().Y));

            guiList.Add(bg);
            guiList.Add(header);
            guiList.Add(buttonPlay);
            guiList.Add(buttonExit);
            guiList.Add(cursor);
        }

        void buttonPlay_onMouseClick(object sender, EventArgs e)
        {
            GameMain.GetGuiManager().SetGui(new LoadNewGui(game));
        }

        void buttonExit_onMouseClick(object sender, EventArgs e)
        {
            game.Exit();
        }
    }
}
