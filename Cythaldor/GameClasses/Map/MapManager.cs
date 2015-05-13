using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor.GameClasses.Map
{
    public class MapManager
    {

        Map actualMap;

        public MapManager(Map map)
        {
            actualMap = map;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        public Map GetMap()
        {
            return actualMap;
        }

        public void SetMap(Map map)
        {
            actualMap = map;
        }


    }
}
