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

        private SpriteFont font;
        private string text;
        private Color textColor;
        private Vector2 textPos = Vector2.Zero;
        

        public Button(Texture2D texture, Rectangle rectangle, Texture2D textureOver = null, string text = null, SpriteFont font = null, Color? textColor = null)
        {
            this.texture = texture;
            this.textureNormal = this.texture;
            this.rectangle = rectangle;
            this.textureOver = textureOver;
            this.text = text;
            this.font = font;
            if (textColor != null)
                this.textColor = (Color)textColor;
            else
                this.textColor = Color.White;
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
            if (text != null && font != null && textColor != null)
            {
                CenterText();
                spriteBatch.DrawString(font, text, textPos, textColor);
            }
        }

        public void Center(int width, int height)
        {
            rectangle.X = (width / 2) - (rectangle.Width / 2);
            rectangle.Y = (height / 2) - (rectangle.Height / 2);
            CenterText();
        }

        public void CenterX(int width, int height)
        {
            rectangle.X = (width / 2) - (rectangle.Width / 2);
            CenterText();
        }

        public void CenterY(int width, int height)
        {
            rectangle.Y = (height / 2) - (rectangle.Height / 2);
            CenterText();
        }

        public void SetPosition(Point position)
        {
            this.rectangle.X = position.X;
            this.rectangle.Y = position.Y;
            CenterText();
        }

        public void SetSize(Point size)
        {
            this.rectangle.Width = size.X;
            this.rectangle.Height = size.Y;
            CenterText();
        }

        public void SetTexture(Texture2D texture)
        {
            this.texture = texture;
        }

        public void SetRectangle(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            CenterText();
        }

        private void CenterText()
        {
            if(text != null && font != null)
                textPos = new Vector2(rectangle.X + (rectangle.Width / 2) - (font.MeasureString(text).X / 2), rectangle.Y + (rectangle.Height / 2) - (font.MeasureString(text).Y / 2));
        }
    }
}
