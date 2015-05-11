using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor.Content
{
    public class ResourcesManager
    {
        private Dictionary<string, object> resources = new Dictionary<string, object>();
        private ContentManager content;

        public ResourcesManager(ContentManager content)
        {
            this.content = content;
        }

        public T GetAsset<T>(string name)
        {
            if (!resources.ContainsKey(name))
                resources.Add(name, content.Load<T>(name));
            return (T)resources[name];
        }

    }
}
