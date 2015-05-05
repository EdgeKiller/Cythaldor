using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor
{
    public class GameScreen : Screen
    {
        Player player;

        public GameScreen()
        {

        }

        public override void LoadContent(ContentManager content)
        {
            Texture2D playerTexture = content.Load<Texture2D>("char_tile");
            player = new Player(playerTexture, Vector2.Zero, Vector2.Zero);
        }

        public override void Update(GameTime gameTime)
        {
            player.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            player.Draw(spriteBatch);
        }
    }
}
