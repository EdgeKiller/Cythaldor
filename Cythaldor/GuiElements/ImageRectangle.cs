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
    public class ImageRectangle : GuiElement
    {
        private Rectangle rectangle;
        private Texture2D texture;
        private Color color;

        public ImageRectangle(string texture, Rectangle rectangle)
        {
            this.texture = GameMain.GetResManager().GetAsset<Texture2D>(texture);
            this.rectangle = rectangle;
        }

        public ImageRectangle(Color color, Rectangle rectangle)
        {
            this.color = color;
            this.rectangle = rectangle;
        }

        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(texture != null)
                spriteBatch.Draw(texture, rectangle, Color.White);
            else
                spriteBatch.Draw(GameMain.GetResManager().GetAsset<Texture2D>("pixel"), rectangle, color);
        }

        public void SetTexture(Texture2D texture)
        {
            this.texture = texture;
        }

        public void SetRectangle(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }


        public void Center(int width, int height)
        {
            rectangle.X = (width / 2) - (rectangle.Width / 2);
            rectangle.Y = (height / 2) - (rectangle.Height / 2);
        }

        public void CenterX(int width, int height)
        {
            rectangle.X = (width / 2) - (rectangle.Width / 2);
        }

        public void CenterY(int width, int height)
        {
            rectangle.Y = (height / 2) - (rectangle.Height / 2);
        }
    }
}
