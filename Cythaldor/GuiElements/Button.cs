using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor.GuiElements
{
    public class Button : GuiElement
    {

        private Texture2D texture, textureNormal, textureOver;
        private Rectangle rectangle;

        private bool over = false, clicked = false;

        public event EventHandler onMouseDown, onMouseOver, onMouseLeave, onMouseClick;
        

        public Button(Texture2D texture, Rectangle rectangle, Texture2D textureOver = null)
        {
            this.texture = texture;
            this.textureNormal = this.texture;
            this.rectangle = rectangle;
            this.textureOver = textureOver;
        }

        public void Update(GameTime gameTime)
        {
            if (new Rectangle(Mouse.GetState().X, Mouse.GetState().Y, 1, 1).Intersects(rectangle))
            {
                over = true;
                if (textureOver != null)
                    SetTexture(textureOver);
                if(onMouseOver != null)
                    onMouseOver.Invoke(new object(), new EventArgs());
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    if (!clicked && onMouseClick != null)
                        onMouseClick.Invoke(new object(), new EventArgs());
                    clicked = true;
                    if (onMouseDown != null)
                        onMouseDown.Invoke(new object(), new EventArgs());
                }
                else
                    clicked = false;
            }
            else if(over == true)
            {
                over = false;
                clicked = false;
                SetTexture(textureNormal);
                if (onMouseLeave != null)
                    onMouseLeave.Invoke(new object(), new EventArgs());
                
            }
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
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

        public void SetPosition(Point position)
        {
            this.rectangle.X = position.X;
            this.rectangle.Y = position.Y;
        }

        public void SetSize(Point size)
        {
            this.rectangle.Width = size.X;
            this.rectangle.Height = size.Y;
        }

        public void SetTexture(Texture2D texture)
        {
            this.texture = texture;
        }

        public void SetRectangle(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }
    }
}
