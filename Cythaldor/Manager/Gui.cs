using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Cythaldor.Manager
{
    public interface Gui
    {
        void Init();

        void LoadContent();

        void Update(GameTime gameTime);

        void Draw(SpriteBatch spriteBatch);

    }
}
