using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace Cythaldor.GameClasses.Utils
{
    public class Camera
    {
        private Vector2 position;


        public Camera(Vector2? position = null)
        {
            if (position == null)
                this.position = Vector2.Zero;
            else
                this.position = (Vector2)position;

        }

        public void AddPosition(int x = 0, int y = 0)
        {
            if (x >= 0 && y >= 0)
                position += new Vector2(x, y);
        }

        public Vector2 GetPosition()
        {
            return position;
        }

        public void SetPosition(Vector2 position)
        {
            if(position.X >= 0 && position.Y >= 0)
                this.position = position;
        }

    }
}
