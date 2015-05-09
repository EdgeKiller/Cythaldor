using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor.Content
{
    public class TextureManager
    {
        private Dictionary<string, Texture2D> textures = new Dictionary<string,Texture2D>();
        private ContentManager content;

        public TextureManager(ContentManager content)
        {
            this.content = content;
        }

        public Texture2D GetAsset(string name)
        {
            if(!textures.ContainsKey(name))
                textures.Add(name, content.Load<Texture2D>(name));
            return textures[name];
        }

    }
}
