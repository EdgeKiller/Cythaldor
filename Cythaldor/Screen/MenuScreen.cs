using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLua;

namespace Cythaldor
{
    public class MenuScreen : Screen
    {
        private Lua lua = new Lua();
        private LuaFunction luaUpdate, luaDraw, luaInit;

        public MenuScreen()
        {

        }

        public override void Initialize()
        {
            lua["this"] = this;
            lua.DoFile("Lua/menu.lua");
            luaUpdate = lua["update"] as LuaFunction;
            luaDraw = lua["draw"] as LuaFunction;
            luaInit = lua["init"] as LuaFunction;
        }

        public override void LoadContent(ContentManager content)
        {

        }

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}
