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

        private Lua lua = new Lua();
        private LuaFunction luaUpdate, luaDraw, luaInit;

        public Player(Texture2D texture, Vector2 position, Vector2 direction)
            : base(texture, position, direction)
        {
            
        }

        public override void Initialize()
        {
            lua["this"] = this;
            lua.DoFile("Lua/player.lua");
            luaUpdate = lua["update"] as LuaFunction;
            luaDraw = lua["draw"] as LuaFunction;
            luaInit = lua["init"] as LuaFunction;
            luaInit.Call();
        }

        public override void Update(GameTime gameTime)
        {
            luaUpdate.Call(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            luaDraw.Call(spriteBatch);
        }

        public Rectangle getSourceRec(int x, int y)
        {
            return new Rectangle((int)x * 30, (int)y * 34, 30, 34);
        }


        public void draw(SpriteBatch spriteBatch, Texture2D texture, Vector2 position, Rectangle source)
        {
            spriteBatch.Draw(texture, position, source, Color.White);
        }

        #region FUNCTIONS
        public bool isKeyDown(int key)
        {
            KeyboardState kbstate = new KeyboardState();
            kbstate = Keyboard.GetState();
            if (kbstate.IsKeyDown((Keys)key))
                return true;
            return false;
        }
        #endregion

    }
}
