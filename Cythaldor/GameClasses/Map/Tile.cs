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
    public class Tile
    {
        private int ID;
        private Texture2D texture;


        public Tile(int ID)
        {
            this.ID = ID;
            this.texture = GameMain.GetResManager().GetAsset<Texture2D>(ID.ToString());
        }

        public Texture2D GetTexture()
        {
            return texture;
        }

        public void SetID(int ID)
        {
            this.ID = ID;
        }

        public int GetID()
        {
            return ID;
        }

    }
}
