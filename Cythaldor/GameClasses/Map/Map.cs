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
    public class Map
    {

        private Tile[][] tileMap;

        public Map(Tile[][] tileMap)
        {
            this.tileMap = tileMap;
        }

        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for(int x = 0; x < tileMap.GetLength(0); x++)
            {
                for(int y = 0; y < tileMap.GetLength(1); y++)
                {
                    spriteBatch.Draw(tileMap[x][y].GetTexture(), new Rectangle(), Color.White);
                }
            }
        }

        public Tile GetTile(int x, int y)
        {
            return tileMap[x][y];
        }

        public int GetTileID(int x, int y)
        {
            return tileMap[x][y].GetID();
        }


    }
}
