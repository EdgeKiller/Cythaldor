using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Cythaldor.GuiElements
{
    public class Cursor : GuiElement
    {
        private Point position = new Point(0,0);
        private Texture2D texture;

        public Cursor(Texture2D texture, Point position)
        {
            this.texture = texture;
            this.position = position;
        }

        public void Update(GameTime gameTime)
        {
            position = Mouse.GetState().Position;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Vector2(position.X, position.Y), Color.White);
        }
    }
}
