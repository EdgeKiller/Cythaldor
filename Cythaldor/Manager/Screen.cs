using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor.Manager
{
    public interface Screen
    {
        void Init();

        void LoadContent(ContentManager content);

        void Update(GameTime gameTime);

        void Draw(SpriteBatch spriteBatch);

    }
}
