using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Cythaldor.GameClasses.Utils;
using System.IO;

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

        public void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            for(int x = 0; x < tileMap.GetLength(0); x++)
            {
                for(int y = 0; y < tileMap.GetLength(1); y++)
                {
                    spriteBatch.Draw(tileMap[y][x].GetTexture(), new Rectangle(x * 32, y * 16, 32, 16), Color.White);
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

        private Tile[][] LoadMapFromFile(string path)
        {
            string[] mapDatas = File.ReadAllLines(path);
            Tile[][] result;
            for(int y =0; y < mapDatas.GetLength(0); y++)
            {
                string[] lineSplit = mapDatas[y].Split();
                for(int x = 0; x < lineSplit.GetLength(0); x++)
                {
                    //result[y][x] = lineSplit[new Tile(x)];
                }
            }
            return result = new Tile[1][];
        }
    }
}
