using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using NLua;

namespace Cythaldor
{
    public class Sprite
    {
        private Texture2D texture;
        private Vector2 position;

        private Lua lua = new Lua();
        private LuaFunction luaUpdate, luaDraw;

        public Sprite(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
            lua["this"] = this;
            lua["colorWhite"] = Color.White;
            lua.DoFile("player.lua");
            luaUpdate = lua["update"] as LuaFunction;
            luaDraw = lua["draw"] as LuaFunction;
        }

        public void Update(GameTime gameTime)
        {
            luaUpdate.Call();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            luaDraw.Call(spriteBatch);
        }

        public bool isKeyDown(int key)
        {
            KeyboardState kbstate = new KeyboardState();
            kbstate = Keyboard.GetState();
            if (kbstate.IsKeyDown((Keys)key))
                return true;
            return false;
        }

        #region SET/GET

        //Position
        public void setPos(int x, int y)
        {
            this.position = new Vector2(x, y);
        }
        public Vector2 getPos()
        {
            return this.position;
        }

        //Texture
        public void setTexture(Texture2D texture)
        {
            this.texture = texture;
        }
        public Texture2D getTexture()
        {
            return this.texture;
        }

        #endregion

    }
}
