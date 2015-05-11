using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;

namespace Cythaldor.GuiElements
{
    public class Button : GuiElement
    {

        private Texture2D texture, textureNormal, textureOver;
        private Rectangle rectangle;

        private bool over = false, clicked = false, soundPlayed = false;

        public event EventHandler onMouseDown, onMouseOver, onMouseLeave, onMouseClick;

        private SpriteFont font = null;
        private string text = null;
        private Color textColor = Color.White;
        private Vector2 textPos = Vector2.Zero;

        private SoundEffect soundOver = GameMain.resManager.GetAsset<SoundEffect>("button_over");
        private SoundEffect soundClick = GameMain.resManager.GetAsset<SoundEffect>("button_click");

        public Button(string texture, Rectangle rectangle, string textureOver = null)
        {
            this.texture = GameMain.resManager.GetAsset<Texture2D>(texture);
            this.textureNormal = this.texture;
            this.rectangle = rectangle;
            if (textureOver != null)
                this.textureOver = GameMain.resManager.GetAsset<Texture2D>(textureOver);
        }

        public Button(string texture, Rectangle rectangle, string text, string font, Color textColor, string textureOver = null)
        {
            this.texture = GameMain.resManager.GetAsset<Texture2D>(texture);
            this.textureNormal = this.texture;
            this.rectangle = rectangle;
            if(textureOver != null)
                this.textureOver = GameMain.resManager.GetAsset<Texture2D>(textureOver);
            this.text = text;
            this.font = GameMain.resManager.GetAsset<SpriteFont>(font);
            if (textColor != null)
                this.textColor = textColor;
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
                if (!soundPlayed)
                {
                    soundOver.Play();
                    soundPlayed = true;
                }
                if (onMouseOver != null)
                    onMouseOver.Invoke(new object(), new EventArgs());
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    if (!clicked)
                    {
                        soundClick.Play();
                        if(onMouseClick != null)
                            onMouseClick.Invoke(new object(), new EventArgs());
                    }
                    clicked = true;
                    if (onMouseDown != null)
                        onMouseDown.Invoke(new object(), new EventArgs());
                }
                else
                    clicked = false;
            }
            else if (over)
            {
                over = false;
                SetTexture(textureNormal);
                if (soundPlayed)
                    soundPlayed = false;
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
                spriteBatch.DrawString(font, text, textPos, (Color)textColor);
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

        public void SetClicked()
        {
            clicked = true;
        }

        private void CenterText()
        {
            if (text != null && font != null)
                textPos = new Vector2(rectangle.X + (rectangle.Width / 2) - (font.MeasureString(text).X / 2), rectangle.Y + (rectangle.Height / 2) - (font.MeasureString(text).Y / 2));
        }
    }
}