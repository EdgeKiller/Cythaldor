using NLua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cythaldor
{
    public class Player : Sprite
    {
        private Texture2D texture;
        private Vector2 position, direction;
        private Lua lua = new Lua();
        private LuaFunction luaUpdate, luaDraw;

        public Player(Texture2D texture, Vector2 position, Vector2 direction)
            : base(texture, position, direction)
        {
            lua["this"] = this;
            lua["colorWhite"] = Color.White;
            lua.DoFile("Lua/player.lua");
            luaUpdate = lua["update"] as LuaFunction;
            luaDraw = lua["draw"] as LuaFunction;
        }

        public void Update(GameTime gameTime)
        {
            luaUpdate.Call(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            luaDraw.Call(spriteBatch);
        }

    }
}
