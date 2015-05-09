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
    public interface GuiElement
    {

        void Update(GameTime gameTime);

        void Draw(SpriteBatch spriteBatch);

    }
}
