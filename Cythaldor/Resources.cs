using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor
{
    public static class Resources
    {
        public static Texture2D playerTexture;

        public static void LoadContent(ContentManager content)
        {
            playerTexture = content.Load<Texture2D>("char_tile");
        }

    }
}
